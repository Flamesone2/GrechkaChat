
namespace GrechkaChat
{
    partial class UsersListForm
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
            this.UsersListView = new System.Windows.Forms.ListView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersListView
            // 
            this.UsersListView.FullRowSelect = true;
            this.UsersListView.HideSelection = false;
            this.UsersListView.Location = new System.Drawing.Point(23, 16);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(279, 359);
            this.UsersListView.TabIndex = 0;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(101, 381);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(123, 41);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GrechkaChat.Properties.Resources.гречка;
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.UsersListView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 435);
            this.panel1.TabIndex = 2;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GrechkaChat.Properties.Resources.гречка;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(364, 489);
            this.MinimumSize = new System.Drawing.Size(364, 489);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel panel1;
    }
}