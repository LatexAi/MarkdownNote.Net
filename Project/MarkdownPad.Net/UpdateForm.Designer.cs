namespace MarkdownNote.Net {
    partial class UpdateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonCheckUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateNow = new System.Windows.Forms.Button();
            this.textBoxUpdateInfo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheckUpdate
            // 
            this.buttonCheckUpdate.Image = global::MarkdownNote.Net.Properties.Resources.update;
            this.buttonCheckUpdate.Location = new System.Drawing.Point(149, 68);
            this.buttonCheckUpdate.Name = "buttonCheckUpdate";
            this.buttonCheckUpdate.Size = new System.Drawing.Size(52, 52);
            this.buttonCheckUpdate.TabIndex = 0;
            this.buttonCheckUpdate.UseVisualStyleBackColor = true;
            this.buttonCheckUpdate.Click += new System.EventHandler(this.buttonCheckUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "如果你需要查找MarkdownNote.Net的更新版本，请点击\r\n立刻检查更新按钮。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(137, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "立刻检查更新";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdateNow);
            this.groupBox1.Controls.Add(this.textBoxUpdateInfo);
            this.groupBox1.Location = new System.Drawing.Point(13, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更新";
            // 
            // buttonUpdateNow
            // 
            this.buttonUpdateNow.Enabled = false;
            this.buttonUpdateNow.Location = new System.Drawing.Point(127, 123);
            this.buttonUpdateNow.Name = "buttonUpdateNow";
            this.buttonUpdateNow.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateNow.TabIndex = 2;
            this.buttonUpdateNow.Text = "立即更新";
            this.buttonUpdateNow.UseVisualStyleBackColor = true;
            // 
            // textBoxUpdateInfo
            // 
            this.textBoxUpdateInfo.Location = new System.Drawing.Point(17, 20);
            this.textBoxUpdateInfo.Multiline = true;
            this.textBoxUpdateInfo.Name = "textBoxUpdateInfo";
            this.textBoxUpdateInfo.ReadOnly = true;
            this.textBoxUpdateInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUpdateInfo.Size = new System.Drawing.Size(290, 97);
            this.textBoxUpdateInfo.TabIndex = 1;
            this.textBoxUpdateInfo.Text = "等待检查更新...";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheckUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件更新";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdateNow;
        private System.Windows.Forms.TextBox textBoxUpdateInfo;
    }
}