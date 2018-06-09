namespace Tyranny.GoogleTranslator
{
    partial class TyrannyGoogleTranslatorFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TyrannyGoogleTranslatorFrm));
            this.label1 = new System.Windows.Forms.Label();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._editSourceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._editTarget = new System.Windows.Forms.TextBox();
            this._btnTranslate = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this._lnkReverse = new System.Windows.Forms.LinkLabel();
            this._btnSpeak = new System.Windows.Forms.Button();
            this._webBrowserCtrl = new System.Windows.Forms.WebBrowser();
            this._lnkSourceEnglish = new System.Windows.Forms.LinkLabel();
            this._lnkTargetEnglish = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source language:";
            // 
            // _comboFrom
            // 
            this._comboFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Location = new System.Drawing.Point(4, 412);
            this._comboFrom.MaxDropDownItems = 20;
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(156, 21);
            this._comboFrom.Sorted = true;
            this._comboFrom.TabIndex = 1;
            // 
            // _comboTo
            // 
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(180, 412);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(156, 21);
            this._comboTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target language:";
            // 
            // _editSourceText
            // 
            this._editSourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editSourceText.Location = new System.Drawing.Point(4, 456);
            this._editSourceText.Multiline = true;
            this._editSourceText.Name = "_editSourceText";
            this._editSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editSourceText.Size = new System.Drawing.Size(778, 60);
            this._editSourceText.TabIndex = 0;
            this._editSourceText.Text = "teste";
            this._editSourceText.TextChanged += new System.EventHandler(this._editSourceText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Source text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Translation (non-Western characters may not display correctly):";
            // 
            // _editTarget
            // 
            this._editTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editTarget.Location = new System.Drawing.Point(4, 536);
            this._editTarget.Multiline = true;
            this._editTarget.Name = "_editTarget";
            this._editTarget.ReadOnly = true;
            this._editTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editTarget.Size = new System.Drawing.Size(778, 60);
            this._editTarget.TabIndex = 10;
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTranslate.Location = new System.Drawing.Point(626, 604);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(75, 23);
            this._btnTranslate.TabIndex = 13;
            this._btnTranslate.Text = "Translate";
            this._btnTranslate.UseVisualStyleBackColor = true;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(2, 608);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(16, 13);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = "   ";
            // 
            // _lnkReverse
            // 
            this._lnkReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lnkReverse.AutoSize = true;
            this._lnkReverse.Location = new System.Drawing.Point(738, 440);
            this._lnkReverse.Name = "_lnkReverse";
            this._lnkReverse.Size = new System.Drawing.Size(47, 13);
            this._lnkReverse.TabIndex = 7;
            this._lnkReverse.TabStop = true;
            this._lnkReverse.Text = "Reverse";
            this._lnkReverse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkReverse_LinkClicked);
            // 
            // _btnSpeak
            // 
            this._btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSpeak.Location = new System.Drawing.Point(706, 604);
            this._btnSpeak.Name = "_btnSpeak";
            this._btnSpeak.Size = new System.Drawing.Size(75, 23);
            this._btnSpeak.TabIndex = 14;
            this._btnSpeak.Text = "Speak";
            this._btnSpeak.UseVisualStyleBackColor = true;
            this._btnSpeak.Click += new System.EventHandler(this._btnSpeak_Click);
            // 
            // _webBrowserCtrl
            // 
            this._webBrowserCtrl.IsWebBrowserContextMenuEnabled = false;
            this._webBrowserCtrl.Location = new System.Drawing.Point(104, 606);
            this._webBrowserCtrl.Name = "_webBrowserCtrl";
            this._webBrowserCtrl.Size = new System.Drawing.Size(68, 20);
            this._webBrowserCtrl.TabIndex = 12;
            this._webBrowserCtrl.Visible = false;
            this._webBrowserCtrl.WebBrowserShortcutsEnabled = false;
            // 
            // _lnkSourceEnglish
            // 
            this._lnkSourceEnglish.AutoSize = true;
            this._lnkSourceEnglish.Location = new System.Drawing.Point(124, 396);
            this._lnkSourceEnglish.Name = "_lnkSourceEnglish";
            this._lnkSourceEnglish.Size = new System.Drawing.Size(40, 13);
            this._lnkSourceEnglish.TabIndex = 2;
            this._lnkSourceEnglish.TabStop = true;
            this._lnkSourceEnglish.Text = "English";
            this._lnkSourceEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkSourceEnglish_LinkClicked);
            // 
            // _lnkTargetEnglish
            // 
            this._lnkTargetEnglish.AutoSize = true;
            this._lnkTargetEnglish.Location = new System.Drawing.Point(276, 396);
            this._lnkTargetEnglish.Name = "_lnkTargetEnglish";
            this._lnkTargetEnglish.Size = new System.Drawing.Size(62, 13);
            this._lnkTargetEnglish.TabIndex = 5;
            this._lnkTargetEnglish.TabStop = true;
            this._lnkTargetEnglish.Text = "Portuguese";
            this._lnkTargetEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkTargetEnglish_LinkClicked);
            // 
            // TyrannyGoogleTranslatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(794, 637);
            this.Controls.Add(this._lnkTargetEnglish);
            this.Controls.Add(this._lnkSourceEnglish);
            this.Controls.Add(this._webBrowserCtrl);
            this.Controls.Add(this._btnSpeak);
            this.Controls.Add(this._lnkReverse);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._editTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._editSourceText);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 676);
            this.MinimumSize = new System.Drawing.Size(810, 676);
            this.Name = "TyrannyGoogleTranslatorFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tyranny Google Translator";
            this.Load += new System.EventHandler(this.GoogleTranslatorFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _editSourceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _editTarget;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.LinkLabel _lnkReverse;
        private System.Windows.Forms.Button _btnSpeak;
        private System.Windows.Forms.WebBrowser _webBrowserCtrl;
        private System.Windows.Forms.LinkLabel _lnkSourceEnglish;
        private System.Windows.Forms.LinkLabel _lnkTargetEnglish;
    }
}