using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadAbout : StaticFileUploadBase
    {
        public StaticFileUploadAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://me.alipay.com/97world");
        }
    }
}
