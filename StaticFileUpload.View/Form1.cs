using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticFileUpload.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitForm();
        }

        public void InitForm()
        {
            Icon testIcon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.BaseDirectory);
            string testStr = AppDomain.CurrentDomain.BaseDirectory;
            pictureBox1.Image = testIcon.ToBitmap();
        }
    }
}
