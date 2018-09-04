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

    public partial class PreferenceForm : Form {

        public PreferenceForm() {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.NdLang);
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }

        private void PreferenceForm_Load(object sender, EventArgs e) {
            if (Properties.Settings.Default.NdMinguoYear) {
                radioYearMinguo.Checked = true;
            } else {
                radioYearWest.Checked = true;
            }

            switch (Properties.Settings.Default.NdLang) {
                case "zh-CN":
                    radioLangChs.Checked = true;
                    break;
                case "zh-TW":
                    radioLangCht.Checked = true;
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            if (radioYearMinguo.Checked) {
                Properties.Settings.Default.NdMinguoYear = true;
            } else {
                Properties.Settings.Default.NdMinguoYear = false;
            }

            if (radioLangEng.Checked) {
                Properties.Settings.Default.NdLang = "en-US";
            }

            if (radioLangChs.Checked) {
                Properties.Settings.Default.NdLang = "zh-CN";
            }

            if (radioLangCht.Checked) {
                Properties.Settings.Default.NdLang = "zh-TW";
            }

            Properties.Settings.Default.Save();

            MessageBox.Show(Properties.Resources.MsPrefNeedRest, Properties.Resources.MsPrefNeedRestTitle, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.Close();
        }
    }
}