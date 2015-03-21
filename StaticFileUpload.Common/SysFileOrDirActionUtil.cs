using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace StaticFileUpload.Common
{
    public class SysFileOrDirActionUtil
    {
        public enum FileFuncFlags : uint
        {
            FO_MOVE = 0x1,
            FO_COPY = 0x2,
            FO_DELETE = 0x3,
            FO_RENAME = 0x4
        }
        [Flags]
        public enum FILEOP_FLAGS : ushort
        {
            FOF_MULTIDESTFILES = 0x1,
            FOF_CONFIRMMOUSE = 0x2,
            FOF_SILENT = 0x4,
            FOF_RENAMEONCOLLISION = 0x8,
            FOF_NOCONFIRMATION = 0x10,
            FOF_WANTMAPPINGHANDLE = 0x20,
            FOF_ALLOWUNDO = 0x40,
            FOF_FILESONLY = 0x80,
            FOF_SIMPLEPROGRESS = 0x100,
            FOF_NOCONFIRMMKDIR = 0x200,
            FOF_NOERRORUI = 0x400,
            FOF_NOCOPYSECURITYATTRIBS = 0x800,
            FOF_NORECURSION = 0x1000,
            FOF_NO_CONNECTED_ELEMENTS = 0x2000,
            FOF_WANTNUKEWARNING = 0x4000,
            FOF_NORECURSEREPARSE = 0x8000
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            public FileFuncFlags wFunc;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pFrom;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pTo;
            public FILEOP_FLAGS fFlags;
            [MarshalAs(UnmanagedType.Bool)]
            public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpszProgressTitle;
        }
        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        public static extern int SHFileOperation([In] ref SHFILEOPSTRUCT lpFileOp);

        [DllImport("shell32.dll")]
        public static extern int ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        public static int DeleteFileOrDirectory(StringBuilder pathSb)
        {
            SHFILEOPSTRUCT shfileopstruct = new SHFILEOPSTRUCT();
            shfileopstruct.hwnd = IntPtr.Zero;
            shfileopstruct.wFunc = FileFuncFlags.FO_DELETE;
            shfileopstruct.pFrom = pathSb.ToString();
            shfileopstruct.hNameMappings = IntPtr.Zero;
            shfileopstruct.fFlags = FILEOP_FLAGS.FOF_ALLOWUNDO;
            shfileopstruct.fAnyOperationsAborted = true;
            return SHFileOperation(ref shfileopstruct);
        }

        public static int CopyFileOrDirectory(StringBuilder sourcePath, string targetPath)
        {
            SHFILEOPSTRUCT shfileopstruct = new SHFILEOPSTRUCT();
            shfileopstruct.hwnd = IntPtr.Zero;
            shfileopstruct.wFunc = FileFuncFlags.FO_COPY;
            shfileopstruct.pFrom = sourcePath.ToString();
            shfileopstruct.pTo = targetPath.ToString();
            shfileopstruct.hNameMappings = IntPtr.Zero;
            shfileopstruct.fFlags = FILEOP_FLAGS.FOF_ALLOWUNDO;
            shfileopstruct.fAnyOperationsAborted = true;
            return SHFileOperation(ref shfileopstruct);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;

        public static int PropertyFileOrDirectory(string path)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = path.ToString();
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }
    }
}
