using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MarkdownNote.Net {
    public partial class NoteMain : Form {
        
        private Boolean mouseDown = false, sizeChanged = false, needSave = false;

        private String fileSavePath = "";

        private UpdateForm updateForm;

        private AboutForm aboutForm;

        public NoteMain() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            compareControlSize();
            int mainVer = (new WebBrowser()).Version.Major;
            if (mainVer < 8) {
                MessageBox.Show("Internet Explorer版本过低，" + Environment.NewLine 
                    + "为保证显示效果，请升级到Internet Explorer 8及更高版本。"
                    + Environment.NewLine + Environment.NewLine + "虽然可以继续使用，但Markdown可能无法正确显示。", 
                    "MarkdownNote.Net", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {
            compareControlSize();
        }

        private void compareControlSize() {
            if (!sizeChanged) {
                textBoxFrom.Width = (this.Width / 2) - 2;
                webBrowserTo.Left = (textBoxFrom.Width) + 4;
                webBrowserTo.Width = (this.Width / 2) - 2;
                panelHandle.Width = 4;
                panelHandle.Left = textBoxFrom.Width;
            } else {
                panelHandle.Left = textBoxFrom.Width;
                webBrowserTo.Left = panelHandle.Left + 4;
                webBrowserTo.Width = this.Width - webBrowserTo.Left;
            }
        }

        private void panelHandle_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
        }

        private void panelHandle_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void panelHandle_MouseLeave(object sender, EventArgs e) {
            mouseDown = false;
        }

        private void 恢复初始视图RToolStripMenuItem_Click(object sender, EventArgs e) {
            sizeChanged = false;
            compareControlSize();
        }

        private void 默认窗体大小ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Width = 800;
            this.Height = 600;
        }

        private void 退出QToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e) {
            if (!needSave) {
                this.Text = "[未保存] " + this.Text;
            }
            needSave = true;
            String headHtml = "<!doctype html><html><head><meta http-equiv=\"content-type\" Content=\"text/html;charset=utf-8\"/><style>body{font-family:\"Microsoft Yahei\";}</style></head><body>";
            String content = Markdown.ToHtml(textBoxFrom.Text.ToString());
            String endHtml = "</body></html>";
            webBrowserTo.DocumentText = headHtml + content + endHtml;
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e) {
            textBoxFrom.SelectAll();
        }

        private void NoteMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (needSave) {
                DialogResult result = MessageBox.Show("文件未保存，需要保存吗？", "MarkdownNote.Net", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    e.Cancel = true;
                    saveAction();
                } else if (result == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }

        private void 退出QToolStripMenuItem_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }

        private void NewOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (needSave) {
                DialogResult result = MessageBox.Show("文件未保存，需要保存吗？", "MarkdownNote.Net", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) {
                    saveAction();
                    return;
                } else if (result == DialogResult.Cancel) {
                    return;
                }
                textBoxFrom.Text = "";
                this.Text = "新建Markdown笔记 - MarkdownNote.Net";
                needSave = false;
            }
        }

        private void 打开OToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (needSave) {
                DialogResult result = MessageBox.Show("文件未保存，需要保存吗？", "MarkdownNote.Net", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    saveAction();
                    return;
                } else if (result == DialogResult.Cancel) {
                    return;
                }
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Markdown文件(*.md)|*.md";
            if (dialog.ShowDialog() == DialogResult.OK) {
                string file = dialog.FileName;
                textBoxFrom.Text = Utils.ReadFromFile(file);
                this.Text = file + " - MarkdownNote.Net";
                fileSavePath = file;
                needSave = false;
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            saveAction();
        }

        private void saveAction() {
            if (!fileSavePath.Equals("")) {
                Utils.WriteToFile(fileSavePath, textBoxFrom.Text.ToString());
                this.Text = fileSavePath + " - MarkdownNote.Net";
                needSave = false;
            } else {
                saveToFile();
            }
        }

        private void saveToFile() {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Markdown文件(*.md)|*.md";
            dialog.AddExtension = true;//设置自动在文件名中添加扩展名
            if (dialog.ShowDialog() == DialogResult.OK) {
                string file = dialog.FileName;
                Utils.WriteToFile(file, textBoxFrom.Text.ToString());
                this.Text = file + " - MarkdownNote.Net";
                fileSavePath = file;
                needSave = false;
            }
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e) {
            saveToFile();
        }

        private void 导出为HTML网页HToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "HTML文件(*.html)|*.html";
            dialog.AddExtension = true;//设置自动在文件名中添加扩展名
            if (dialog.ShowDialog() == DialogResult.OK) {
                string file = dialog.FileName;
                Utils.WriteToFile(file, Markdown.ToHtml(textBoxFrom.Text.ToString()));
            }
        }

        private void insertText(String text) {
            int selectIndex = textBoxFrom.SelectionStart;
            textBoxFrom.Text = textBoxFrom.Text.Insert((textBoxFrom.SelectionStart + textBoxFrom.SelectionLength), text);
            textBoxFrom.SelectionStart = selectIndex + text.Length;
        }

        private void 一级标题ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("# ");

        private void 二级标题ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("## ");

        private void 三级标题ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("### ");

        private void 四级标题ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("#### ");

        private void 五级标题ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("##### ");

        private void 六级标题ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("###### ");

        private void 分割线ToolStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                insertText(Environment.NewLine + "* 列表内容");
            }
        }

        private void 有序列表ToolStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                insertText(Environment.NewLine + i + ". 列表内容");
            }
        }

        private void 链接ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("[名称](url)");

        private void 引用ToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText("> 引用文本");
            textBoxFrom.Select(textBoxFrom.SelectionStart - 4, 4);
        }

        private void 粗体ToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText("**粗体文本**");
            textBoxFrom.Select(textBoxFrom.SelectionStart - 6, 4);
        }

        private void 图片ToolStripMenuItem_Click(object sender, EventArgs e) => insertText("![图片描述](url)");

        private void javaToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText(Environment.NewLine + "```Java" + Environment.NewLine + "//Java code here" + Environment.NewLine + "```");
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText(Environment.NewLine + "```C#" + Environment.NewLine + "//C# code here" + Environment.NewLine + "```");
        }

        private void swiftToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText(Environment.NewLine + "```Swift" + Environment.NewLine + "//Swift code here" + Environment.NewLine + "```");
        }

        private void 其他ToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText(Environment.NewLine + "```Other" + Environment.NewLine + "//Code here" + Environment.NewLine + "```");
        }

        private void 分割线ToolStripMenuItem1_Click(object sender, EventArgs e) {
            insertText(Environment.NewLine + "***");
        }

        private void 斜体ToolStripMenuItem_Click(object sender, EventArgs e) {
            insertText("*斜体文本*");
            textBoxFrom.Select(textBoxFrom.SelectionStart - 5, 4);
        }

        private void 检查更新VToolStripMenuItem_Click(object sender, EventArgs e) {
            if (updateForm != null) {
                updateForm.Activate();
            } else {
                updateForm = new UpdateForm();
                updateForm.Show();
                updateForm.Activate();
                updateForm.FormClosed += updateFormClosed;
            }
        }

        void updateFormClosed(object sender, FormClosedEventArgs e) {
            updateForm.Dispose();
            updateForm = null;
            Utils.ReleaseMemory(true);
        }

        private void 关于MarkdownPadNetAToolStripMenuItem_Click(object sender, EventArgs e) {
            if (aboutForm != null) {
                aboutForm.Activate();
            } else {
                aboutForm = new AboutForm();
                aboutForm.Show();
                aboutForm.Activate();
                aboutForm.FormClosed += aboutFormClosed;
            }
        }

        void aboutFormClosed(object sender, FormClosedEventArgs e) {
            aboutForm.Dispose();
            aboutForm = null;
            Utils.ReleaseMemory(true);
        }

        private void 时间和日期DToolStripMenuItem_Click(object sender, EventArgs e) {
            int index = textBoxFrom.SelectionStart;
            String text = DateTime.Now.ToString("hh:mm") + " " + DateTime.Now.Date.ToShortDateString();
            textBoxFrom.Text = textBoxFrom.Text.Insert(index, text);
            textBoxFrom.SelectionStart = index + text.Length;
            textBoxFrom.Focus();
        }

        private void panelHandle_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                panelHandle.Left = panelHandle.Left + e.X;
                textBoxFrom.Width = panelHandle.Left;
                webBrowserTo.Left = panelHandle.Left + 4;
                webBrowserTo.Width = (this.Width - panelHandle.Left) + 4;
                sizeChanged = true;
            }
        }
        
    }
}
