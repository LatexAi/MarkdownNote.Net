using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MarkdownNote.Net {
    public partial class AboutForm : Form {
        public AboutForm() {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.NdLang);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();       //关闭窗体
        }

        private void AboutForm_Load(object sender, EventArgs e) {
            label5.Text += VersionControl.VERSION_NAME;     //附加从版本控制类获取的版本名称
        }
    }
}
