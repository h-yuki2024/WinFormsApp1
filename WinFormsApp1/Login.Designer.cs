namespace WinFormsApp1
{
    partial class Login
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
            EMailLabel = new Label();
            PASSLabel = new Label();
            EMailTextBox = new TextBox();
            PASSTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // EMailLabel
            // 
            EMailLabel.Anchor = AnchorStyles.Left;
            EMailLabel.AutoSize = true;
            EMailLabel.Location = new Point(204, 155);
            EMailLabel.Name = "EMailLabel";
            EMailLabel.Size = new Size(68, 15);
            EMailLabel.TabIndex = 0;
            EMailLabel.Text = "メールアドレス";
            // 
            // PASSLabel
            // 
            PASSLabel.Anchor = AnchorStyles.Left;
            PASSLabel.AutoSize = true;
            PASSLabel.Location = new Point(238, 256);
            PASSLabel.Name = "PASSLabel";
            PASSLabel.Size = new Size(34, 15);
            PASSLabel.TabIndex = 1;
            PASSLabel.Text = "PASS";
            // 
            // EMailTextBox
            // 
            EMailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            EMailTextBox.Location = new Point(354, 155);
            EMailTextBox.MaxLength = 32;
            EMailTextBox.Name = "EMailTextBox";
            EMailTextBox.Size = new Size(239, 23);
            EMailTextBox.TabIndex = 2;
            // 
            // PASSTextBox
            // 
            PASSTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PASSTextBox.Location = new Point(354, 256);
            PASSTextBox.MaxLength = 8;
            PASSTextBox.Name = "PASSTextBox";
            PASSTextBox.PasswordChar = '●';
            PASSTextBox.Size = new Size(239, 23);
            PASSTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Right;
            LoginButton.Location = new Point(528, 353);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(65, 32);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "ログイン";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += Button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(LoginButton);
            Controls.Add(PASSTextBox);
            Controls.Add(EMailTextBox);
            Controls.Add(PASSLabel);
            Controls.Add(EMailLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EMailLabel;
        private Label PASSLabel;
        private TextBox EMailTextBox;
        private TextBox PASSTextBox;
        private Button LoginButton;
    }
}
