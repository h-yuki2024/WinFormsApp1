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
            label1 = new Label();
            label2 = new Label();
            IDTextBox = new TextBox();
            PASSTextBox = new TextBox();
            Button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 120);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 210);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "PASS";
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
            // Button1
            // 
            Button1.Location = new Point(520, 286);
            Button1.Name = "Button1";
            Button1.Size = new Size(65, 32);
            Button1.TabIndex = 4;
            Button1.Text = "ログイン";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button1);
            Controls.Add(PASSTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox IDTextBox;
        private TextBox PASSTextBox;
        private Button Button1;
    }
}
