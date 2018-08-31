using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MarkdownNote.Net {
    public partial class UpdateForm : Form {

        private String jsonStr = "";

        private JObject updateCat;

        public UpdateForm() {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e) {

        }

        private void GetWebCode(String url) {
            textBoxUpdateInfo.Text = "正在检查更新...";
            buttonCheckUpdate.Enabled = false;
            buttonUpdateNow.Enabled = false;
            WebClient http = new WebClient();
            http.DownloadStringCompleted += http_DownloadStringCompleted;
            http.DownloadStringAsync(new Uri(url));
        }

        private void CheckForUpdate() {
            JObject jObject = (JObject)JsonConvert.DeserializeObject(jsonStr);
            updateCat = (JObject)JsonConvert.DeserializeObject(jObject.GetValue("Update").ToString());
            if (VersionControl.VERSION_CODE < (int)updateCat["code"]) {
                String updateText = "发现新的更新" + Environment.NewLine + "版本：" + VersionControl.VERSION_NAME +
                    " > " + updateCat["name"].ToString() + Environment.NewLine + updateCat["info"].ToString().Replace("<#NL>", Environment.NewLine);
                textBoxUpdateInfo.Text = updateText;
                buttonUpdateNow.Enabled = true;
                buttonUpdateNow.Click += buttonUpdateNow_Click;
            } else {
                textBoxUpdateInfo.Text = "没有更新。";
            }
        }

        private void buttonUpdateNow_Click(object sender, EventArgs e) {
            if (updateCat["password"].ToString().Equals("No")) {
                System.Diagnostics.Process.Start(updateCat["link"].ToString());
            } else {
                MessageBox.Show("请记住下载密码：" + updateCat["password"].ToString(), "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(updateCat["link"].ToString());
            }
        }

        private void http_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e) {
            
            try {
                jsonStr = Encoding.UTF8.GetString(Encoding.Default.GetBytes(e.Result));
                CheckForUpdate();
            } catch (Exception ex) {
                MessageBox.Show("发生错误，无法检查更新，请反馈错误给开发者。" + Environment.NewLine + ex.ToString(),
                    "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Dispose();
            }
        }

        private void buttonCheckUpdate_Click(object sender, EventArgs e) {
            String serverUrl = "https://raw.githubusercontent.com/lkyear/lllw/gh-pages/pwdgen/update.html";
            GetWebCode(serverUrl);
        }
    }
}
