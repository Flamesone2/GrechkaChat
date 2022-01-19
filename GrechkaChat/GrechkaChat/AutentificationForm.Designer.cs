
namespace GrechkaChat
{
    partial class AutentificationForm
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.SignUpBox = new System.Windows.Forms.Button();
            this.passwordProofBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(16, 148);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(222, 20);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(16, 196);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(222, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(16, 274);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(222, 36);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Войти";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(16, 18);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(222, 99);
            this.InfoTextBox.TabIndex = 3;
            // 
            // SignUpBox
            // 
            this.SignUpBox.Location = new System.Drawing.Point(16, 316);
            this.SignUpBox.Name = "SignUpBox";
            this.SignUpBox.Size = new System.Drawing.Size(222, 36);
            this.SignUpBox.TabIndex = 4;
            this.SignUpBox.Text = "Регистрация";
            this.SignUpBox.UseVisualStyleBackColor = true;
            this.SignUpBox.Click += new System.EventHandler(this.SignUpBox_Click);
            // 
            // passwordProofBox
            // 
            this.passwordProofBox.Location = new System.Drawing.Point(16, 248);
            this.passwordProofBox.Name = "passwordProofBox";
            this.passwordProofBox.Size = new System.Drawing.Size(222, 20);
            this.passwordProofBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Повтор пароля";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordProofBox);
            this.groupBox1.Controls.Add(this.SignUpBox);
            this.groupBox1.Controls.Add(this.InfoTextBox);
            this.groupBox1.Controls.Add(this.SignInButton);
            this.groupBox1.Controls.Add(this.passwordBox);
            this.groupBox1.Controls.Add(this.loginBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 371);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вход";
            // 
            // AutentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GrechkaChat.Properties.Resources.гречка;
            this.ClientSize = new System.Drawing.Size(333, 434);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(349, 473);
            this.MinimumSize = new System.Drawing.Size(349, 473);
            this.Name = "AutentificationForm";
            this.Text = "AutentificationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutentificationForm_FormClosing);
            this.Load += new System.EventHandler(this.AutentificationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Button SignUpBox;
        private System.Windows.Forms.TextBox passwordProofBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}