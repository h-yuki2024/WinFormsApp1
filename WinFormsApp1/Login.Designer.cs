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
            IDLabel = new Label();
            PASSLabel = new Label();
            IDTextBox = new TextBox();
            PASSTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(254, 120);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(18, 15);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID";
            // 
            // PASSLabel
            // 
            PASSLabel.AutoSize = true;
            PASSLabel.Location = new Point(238, 210);
            PASSLabel.Name = "PASSLabel";
            PASSLabel.Size = new Size(34, 15);
            PASSLabel.TabIndex = 1;
            PASSLabel.Text = "PASS";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.Location = new Point(354, 120);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(231, 23);
            IDTextBox.TabIndex = 2;
            // 
            // PASSTextBox
            // 
            PASSTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PASSTextBox.Location = new Point(354, 202);
            PASSTextBox.Name = "PASSTextBox";
            PASSTextBox.Size = new Size(231, 23);
            PASSTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(520, 286);
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
            ClientSize = new Size(800, 450);
            Controls.Add(LoginButton);
            Controls.Add(PASSTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(PASSLabel);
            Controls.Add(IDLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private Label PASSLabel;
        private TextBox IDTextBox;
        private TextBox PASSTextBox;
        private Button LoginButton;
    }
}
