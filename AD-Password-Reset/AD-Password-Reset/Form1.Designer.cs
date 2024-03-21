namespace AD_Password_Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Username = new Label();
            usernameBox = new TextBox();
            NewPassword = new Label();
            newPasswordBox = new TextBox();
            button1 = new Button();
            usernameDrop = new ComboBox();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Username.Location = new Point(12, 19);
            Username.Name = "Username";
            Username.Size = new Size(146, 37);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(12, 121);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(367, 23);
            usernameBox.TabIndex = 1;
            // 
            // NewPassword
            // 
            NewPassword.AutoSize = true;
            NewPassword.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            NewPassword.Location = new Point(12, 157);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(204, 37);
            NewPassword.TabIndex = 2;
            NewPassword.Text = "New Password";
            // 
            // newPasswordBox
            // 
            newPasswordBox.Location = new Point(12, 219);
            newPasswordBox.Name = "newPasswordBox";
            newPasswordBox.Size = new Size(367, 23);
            newPasswordBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 274);
            button1.Name = "button1";
            button1.Size = new Size(367, 23);
            button1.TabIndex = 4;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // usernameDrop
            // 
            usernameDrop.FormattingEnabled = true;
            usernameDrop.Location = new Point(12, 73);
            usernameDrop.Name = "usernameDrop";
            usernameDrop.Size = new Size(367, 23);
            usernameDrop.TabIndex = 5;
            usernameDrop.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(391, 450);
            Controls.Add(usernameDrop);
            Controls.Add(button1);
            Controls.Add(newPasswordBox);
            Controls.Add(NewPassword);
            Controls.Add(usernameBox);
            Controls.Add(Username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(407, 489);
            MinimumSize = new Size(407, 489);
            Name = "Form1";
            Text = "AD Password Reset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private TextBox usernameBox;
        private Label NewPassword;
        private TextBox newPasswordBox;
        private Button button1;
        private ComboBox usernameDrop;
    }
}
