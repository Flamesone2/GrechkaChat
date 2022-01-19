
namespace GrechkaChat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.message_box = new System.Windows.Forms.TextBox();
            this.chat = new System.Windows.Forms.TextBox();
            this.sender_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConDiscButton = new System.Windows.Forms.Button();
            this.NumberOfUsers = new System.Windows.Forms.Label();
            this.UsersOnlineView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message_box
            // 
            this.message_box.Location = new System.Drawing.Point(13, 336);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(301, 61);
            this.message_box.TabIndex = 0;
            this.message_box.TextChanged += new System.EventHandler(this.message_box_TextChanged);
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(13, 9);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.chat.Size = new System.Drawing.Size(420, 321);
            this.chat.TabIndex = 1;
            this.chat.TextChanged += new System.EventHandler(this.chat_TextChanged);
            // 
            // sender_button
            // 
            this.sender_button.Location = new System.Drawing.Point(320, 336);
            this.sender_button.Name = "sender_button";
            this.sender_button.Size = new System.Drawing.Size(113, 61);
            this.sender_button.TabIndex = 2;
            this.sender_button.Text = "Отправить";
            this.sender_button.UseVisualStyleBackColor = true;
            this.sender_button.Click += new System.EventHandler(this.sender_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GrechkaChat.Properties.Resources.гречка;
            this.panel1.Controls.Add(this.sender_button);
            this.panel1.Controls.Add(this.chat);
            this.panel1.Controls.Add(this.message_box);
            this.panel1.Location = new System.Drawing.Point(179, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 411);
            this.panel1.TabIndex = 3;
            // 
            // ConDiscButton
            // 
            this.ConDiscButton.Location = new System.Drawing.Point(640, 20);
            this.ConDiscButton.Name = "ConDiscButton";
            this.ConDiscButton.Size = new System.Drawing.Size(86, 30);
            this.ConDiscButton.TabIndex = 4;
            this.ConDiscButton.Text = "Подключится";
            this.ConDiscButton.UseVisualStyleBackColor = true;
            this.ConDiscButton.Click += new System.EventHandler(this.ConDiscButton_Click);
            // 
            // NumberOfUsers
            // 
            this.NumberOfUsers.AutoSize = true;
            this.NumberOfUsers.Location = new System.Drawing.Point(637, 98);
            this.NumberOfUsers.Name = "NumberOfUsers";
            this.NumberOfUsers.Size = new System.Drawing.Size(83, 13);
            this.NumberOfUsers.TabIndex = 5;
            this.NumberOfUsers.Text = "Людей онлайн:";
            // 
            // UsersOnlineView
            // 
            this.UsersOnlineView.Location = new System.Drawing.Point(640, 114);
            this.UsersOnlineView.Name = "UsersOnlineView";
            this.UsersOnlineView.Size = new System.Drawing.Size(86, 30);
            this.UsersOnlineView.TabIndex = 6;
            this.UsersOnlineView.Text = "Список";
            this.UsersOnlineView.UseVisualStyleBackColor = true;
            this.UsersOnlineView.Click += new System.EventHandler(this.UsersOnlineView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GrechkaChat.Properties.Resources.гречка;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsersOnlineView);
            this.Controls.Add(this.NumberOfUsers);
            this.Controls.Add(this.ConDiscButton);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.Button sender_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConDiscButton;
        private System.Windows.Forms.Label NumberOfUsers;
        private System.Windows.Forms.Button UsersOnlineView;
    }
}

