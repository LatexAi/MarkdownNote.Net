namespace MarkdownNote.Net {
    partial class SetupForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioEnglish = new System.Windows.Forms.RadioButton();
            this.radioSc = new System.Windows.Forms.RadioButton();
            this.radioTc = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to use MarkdownNote.Net.\r\nPlease choose your language to continue:";
            // 
            // radioEnglish
            // 
            this.radioEnglish.Checked = true;
            this.radioEnglish.Location = new System.Drawing.Point(120, 94);
            this.radioEnglish.Name = "radioEnglish";
            this.radioEnglish.Size = new System.Drawing.Size(198, 30);
            this.radioEnglish.TabIndex = 2;
            this.radioEnglish.TabStop = true;
            this.radioEnglish.Text = "English (U.S)";
            this.radioEnglish.UseVisualStyleBackColor = true;
            // 
            // radioSc
            // 
            this.radioSc.Location = new System.Drawing.Point(120, 130);
            this.radioSc.Name = "radioSc";
            this.radioSc.Size = new System.Drawing.Size(198, 28);
            this.radioSc.TabIndex = 3;
            this.radioSc.Text = "Simplified Chinese / 简体中文";
            this.radioSc.UseVisualStyleBackColor = true;
            // 
            // radioTc
            // 
            this.radioTc.Location = new System.Drawing.Point(120, 164);
            this.radioTc.Name = "radioTc";
            this.radioTc.Size = new System.Drawing.Size(198, 28);
            this.radioTc.TabIndex = 4;
            this.radioTc.Text = "Traditional Chinese / 正體中文";
            this.radioTc.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(160, 217);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 29);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Let\'s write!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 263);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.radioTc);
            this.Controls.Add(this.radioSc);
            this.Controls.Add(this.radioEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup wizard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioEnglish;
        private System.Windows.Forms.RadioButton radioSc;
        private System.Windows.Forms.RadioButton radioTc;
        private System.Windows.Forms.Button buttonStart;
    }
}