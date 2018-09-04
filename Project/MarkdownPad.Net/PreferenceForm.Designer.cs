namespace MarkdownNote.Net
{
    partial class PreferenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenceForm));
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox();
            this.radioLangCht = new System.Windows.Forms.RadioButton();
            this.radioLangChs = new System.Windows.Forms.RadioButton();
            this.radioLangEng = new System.Windows.Forms.RadioButton();
            this.groupBoxCalendar = new System.Windows.Forms.GroupBox();
            this.radioYearMinguo = new System.Windows.Forms.RadioButton();
            this.radioYearWest = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxLanguage.SuspendLayout();
            this.groupBoxCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLanguage
            // 
            resources.ApplyResources(this.groupBoxLanguage, "groupBoxLanguage");
            this.groupBoxLanguage.Controls.Add(this.radioLangCht);
            this.groupBoxLanguage.Controls.Add(this.radioLangChs);
            this.groupBoxLanguage.Controls.Add(this.radioLangEng);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.TabStop = false;
            // 
            // radioLangCht
            // 
            resources.ApplyResources(this.radioLangCht, "radioLangCht");
            this.radioLangCht.Name = "radioLangCht";
            this.radioLangCht.UseVisualStyleBackColor = true;
            // 
            // radioLangChs
            // 
            resources.ApplyResources(this.radioLangChs, "radioLangChs");
            this.radioLangChs.Name = "radioLangChs";
            this.radioLangChs.TabStop = true;
            this.radioLangChs.UseVisualStyleBackColor = true;
            // 
            // radioLangEng
            // 
            resources.ApplyResources(this.radioLangEng, "radioLangEng");
            this.radioLangEng.Checked = true;
            this.radioLangEng.Name = "radioLangEng";
            this.radioLangEng.TabStop = true;
            this.radioLangEng.UseVisualStyleBackColor = true;
            // 
            // groupBoxCalendar
            // 
            resources.ApplyResources(this.groupBoxCalendar, "groupBoxCalendar");
            this.groupBoxCalendar.Controls.Add(this.radioYearMinguo);
            this.groupBoxCalendar.Controls.Add(this.radioYearWest);
            this.groupBoxCalendar.Name = "groupBoxCalendar";
            this.groupBoxCalendar.TabStop = false;
            // 
            // radioYearMinguo
            // 
            resources.ApplyResources(this.radioYearMinguo, "radioYearMinguo");
            this.radioYearMinguo.Name = "radioYearMinguo";
            this.radioYearMinguo.UseVisualStyleBackColor = true;
            // 
            // radioYearWest
            // 
            resources.ApplyResources(this.radioYearWest, "radioYearWest");
            this.radioYearWest.Checked = true;
            this.radioYearWest.Name = "radioYearWest";
            this.radioYearWest.TabStop = true;
            this.radioYearWest.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PreferenceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxCalendar);
            this.Controls.Add(this.groupBoxLanguage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferenceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PreferenceForm_Load);
            this.groupBoxLanguage.ResumeLayout(false);
            this.groupBoxLanguage.PerformLayout();
            this.groupBoxCalendar.ResumeLayout(false);
            this.groupBoxCalendar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.RadioButton radioLangCht;
        private System.Windows.Forms.RadioButton radioLangChs;
        private System.Windows.Forms.RadioButton radioLangEng;
        private System.Windows.Forms.GroupBox groupBoxCalendar;
        private System.Windows.Forms.RadioButton radioYearMinguo;
        private System.Windows.Forms.RadioButton radioYearWest;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}