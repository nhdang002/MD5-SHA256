
namespace WinForms_MD5_and_SHA_256__SHA2_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MD5_ButtonClick = new System.Windows.Forms.Button();
            this.SHA256_Button = new System.Windows.Forms.Button();
            this.m_UserInput_TextBox = new System.Windows.Forms.TextBox();
            this.m_MD5_textbox = new System.Windows.Forms.TextBox();
            this.SHA256_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MD5_ButtonClick
            // 
            this.MD5_ButtonClick.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MD5_ButtonClick.Location = new System.Drawing.Point(476, 293);
            this.MD5_ButtonClick.Name = "MD5_ButtonClick";
            this.MD5_ButtonClick.Size = new System.Drawing.Size(94, 29);
            this.MD5_ButtonClick.TabIndex = 0;
            this.MD5_ButtonClick.Text = "Crea MD5";
            this.MD5_ButtonClick.UseVisualStyleBackColor = false;
            this.MD5_ButtonClick.Click += new System.EventHandler(this.MD5_ButtonClick_);
            // 
            // SHA256_Button
            // 
            this.SHA256_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SHA256_Button.Location = new System.Drawing.Point(686, 322);
            this.SHA256_Button.Name = "SHA256_Button";
            this.SHA256_Button.Size = new System.Drawing.Size(102, 52);
            this.SHA256_Button.TabIndex = 1;
            this.SHA256_Button.Text = "Crea SHA256";
            this.SHA256_Button.UseVisualStyleBackColor = false;
            this.SHA256_Button.Click += new System.EventHandler(this.SHA256_Button_Click);
            // 
            // m_UserInput_TextBox
            // 
            this.m_UserInput_TextBox.Location = new System.Drawing.Point(256, 80);
            this.m_UserInput_TextBox.Name = "m_UserInput_TextBox";
            this.m_UserInput_TextBox.Size = new System.Drawing.Size(381, 27);
            this.m_UserInput_TextBox.TabIndex = 2;
            // 
            // m_MD5_textbox
            // 
            this.m_MD5_textbox.Location = new System.Drawing.Point(112, 293);
            this.m_MD5_textbox.Name = "m_MD5_textbox";
            this.m_MD5_textbox.Size = new System.Drawing.Size(348, 27);
            this.m_MD5_textbox.TabIndex = 3;
            // 
            // SHA256_TextBox
            // 
            this.SHA256_TextBox.Location = new System.Drawing.Point(112, 335);
            this.SHA256_TextBox.Name = "SHA256_TextBox";
            this.SHA256_TextBox.Size = new System.Drawing.Size(561, 27);
            this.SHA256_TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Text to Generate Hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MD5 Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "SHA-256 Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(643, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(33, 113);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(755, 151);
            this.richTextBoxInput.TabIndex = 9;
            this.richTextBoxInput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHA256_TextBox);
            this.Controls.Add(this.m_MD5_textbox);
            this.Controls.Add(this.m_UserInput_TextBox);
            this.Controls.Add(this.SHA256_Button);
            this.Controls.Add(this.MD5_ButtonClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MD5_ButtonClick;
        private System.Windows.Forms.Button SHA256_Button;
        private System.Windows.Forms.TextBox m_UserInput_TextBox;
        private System.Windows.Forms.TextBox m_MD5_textbox;
        private System.Windows.Forms.TextBox SHA256_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
    }
}

