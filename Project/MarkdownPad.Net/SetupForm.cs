using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarkdownNote.Net {

    public partial class SetupForm : Form {

        public SetupForm() {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e) {
            switch (Properties.Settings.Default.NdLang) {
                case "zh-CN":
                    radioSc.Checked = true;
                    break;
                case "zh-TW":
                    radioTc.Checked = true;
                    break;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            if (radioEnglish.Checked) {
                Properties.Settings.Default.NdLang = "en-US";
            }

            if (radioSc.Checked) {
                Properties.Settings.Default.NdLang = "zh-CN";
            }

            if (radioTc.Checked) {
                Properties.Settings.Default.NdLang = "zh-TW";
            }

            Properties.Settings.Default.NdSetup = true;
            Properties.Settings.Default.Save();
            LetsRock();
        }

        private void LetsRock() {
            NoteMain main = new NoteMain();
            main.FormClosed += Main_FormClosed;
            main.Show();
            this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e) {
            this.Close();
        }
    }
}
