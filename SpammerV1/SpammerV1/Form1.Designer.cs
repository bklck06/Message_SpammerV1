namespace SpammerV1
{
    partial class TextSpammerV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextSpammerV1));
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.richTextBoxKopyalananMetin = new System.Windows.Forms.RichTextBox();
            this.copy_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.instagramLinkLabel = new System.Windows.Forms.LinkLabel();
            this.whatsappLinkLabel = new System.Windows.Forms.LinkLabel();
            this.twitterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.richTextBoxClearButton = new System.Windows.Forms.Button();
            this.textBoxClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Location = new System.Drawing.Point(21, 94);
            this.textBoxMetin.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(766, 27);
            this.textBoxMetin.TabIndex = 0;
            // 
            // richTextBoxKopyalananMetin
            // 
            this.richTextBoxKopyalananMetin.Location = new System.Drawing.Point(550, 152);
            this.richTextBoxKopyalananMetin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxKopyalananMetin.Name = "richTextBoxKopyalananMetin";
            this.richTextBoxKopyalananMetin.Size = new System.Drawing.Size(240, 314);
            this.richTextBoxKopyalananMetin.TabIndex = 1;
            this.richTextBoxKopyalananMetin.Text = "";
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(22, 202);
            this.copy_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(223, 48);
            this.copy_button.TabIndex = 2;
            this.copy_button.Text = "Copy X1";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the text to copy :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copied text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(286, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "- Text Spammer V1 -";
            // 
            // txt_button
            // 
            this.txt_button.Location = new System.Drawing.Point(22, 258);
            this.txt_button.Margin = new System.Windows.Forms.Padding(4);
            this.txt_button.Name = "txt_button";
            this.txt_button.Size = new System.Drawing.Size(223, 48);
            this.txt_button.TabIndex = 2;
            this.txt_button.Text = "Import TXT";
            this.txt_button.UseVisualStyleBackColor = true;
            this.txt_button.Click += new System.EventHandler(this.txt_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(305, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "- Made By. Neron V -";
            // 
            // instagramLinkLabel
            // 
            this.instagramLinkLabel.AutoSize = true;
            this.instagramLinkLabel.Location = new System.Drawing.Point(406, 202);
            this.instagramLinkLabel.Name = "instagramLinkLabel";
            this.instagramLinkLabel.Size = new System.Drawing.Size(92, 20);
            this.instagramLinkLabel.TabIndex = 8;
            this.instagramLinkLabel.TabStop = true;
            this.instagramLinkLabel.Text = "Instagram";
            this.instagramLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.instagramLinkLabel_LinkClicked);
            // 
            // whatsappLinkLabel
            // 
            this.whatsappLinkLabel.AutoSize = true;
            this.whatsappLinkLabel.Location = new System.Drawing.Point(406, 222);
            this.whatsappLinkLabel.Name = "whatsappLinkLabel";
            this.whatsappLinkLabel.Size = new System.Drawing.Size(137, 20);
            this.whatsappLinkLabel.TabIndex = 8;
            this.whatsappLinkLabel.TabStop = true;
            this.whatsappLinkLabel.Text = "WhatsApp Web";
            this.whatsappLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.whatsappLinkLabel_LinkClicked);
            // 
            // twitterLinkLabel
            // 
            this.twitterLinkLabel.AutoSize = true;
            this.twitterLinkLabel.Location = new System.Drawing.Point(406, 180);
            this.twitterLinkLabel.Name = "twitterLinkLabel";
            this.twitterLinkLabel.Size = new System.Drawing.Size(67, 20);
            this.twitterLinkLabel.TabIndex = 8;
            this.twitterLinkLabel.TabStop = true;
            this.twitterLinkLabel.Text = "Twitter";
            this.twitterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.twitterLinkLabel_LinkClicked);
            // 
            // richTextBoxClearButton
            // 
            this.richTextBoxClearButton.Location = new System.Drawing.Point(314, 418);
            this.richTextBoxClearButton.Name = "richTextBoxClearButton";
            this.richTextBoxClearButton.Size = new System.Drawing.Size(224, 48);
            this.richTextBoxClearButton.TabIndex = 9;
            this.richTextBoxClearButton.Text = "Clear Copied";
            this.richTextBoxClearButton.UseVisualStyleBackColor = true;
            this.richTextBoxClearButton.Click += new System.EventHandler(this.richTextBoxClearButton_Click);
            // 
            // textBoxClearButton
            // 
            this.textBoxClearButton.Location = new System.Drawing.Point(22, 153);
            this.textBoxClearButton.Name = "textBoxClearButton";
            this.textBoxClearButton.Size = new System.Drawing.Size(223, 47);
            this.textBoxClearButton.TabIndex = 10;
            this.textBoxClearButton.Text = "Clear";
            this.textBoxClearButton.UseVisualStyleBackColor = true;
            this.textBoxClearButton.Click += new System.EventHandler(this.textBoxClearButton_Click);
            // 
            // TextSpammerV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 508);
            this.Controls.Add(this.textBoxClearButton);
            this.Controls.Add(this.richTextBoxClearButton);
            this.Controls.Add(this.twitterLinkLabel);
            this.Controls.Add(this.whatsappLinkLabel);
            this.Controls.Add(this.instagramLinkLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_button);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.richTextBoxKopyalananMetin);
            this.Controls.Add(this.textBoxMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextSpammerV1";
            this.Text = "TextSpammerV1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.RichTextBox richTextBoxKopyalananMetin;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txt_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel instagramLinkLabel;
        private System.Windows.Forms.LinkLabel whatsappLinkLabel;
        private System.Windows.Forms.LinkLabel twitterLinkLabel;
        private System.Windows.Forms.Button richTextBoxClearButton;
        private System.Windows.Forms.Button textBoxClearButton;
    }
}

