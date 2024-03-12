namespace WinFormsApp1
{
    partial class Menu
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
            DataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            toDo = new DataGridViewTextBoxColumn();
            ToDoButton = new Button();
            UserSearchButton = new Button();
            UserRegistrationButton = new Button();
            ShopSearchButton = new Button();
            ShopRegistrationButton = new Button();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, toDo });
            DataGridView1.Location = new Point(304, 73);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(443, 263);
            DataGridView1.TabIndex = 0;
            DataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // no
            // 
            no.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            no.FillWeight = 57.8680267F;
            no.HeaderText = "No";
            no.Name = "no";
            // 
            // toDo
            // 
            toDo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            toDo.FillWeight = 142.131973F;
            toDo.HeaderText = "ToDo";
            toDo.Name = "toDo";
            // 
            // ToDoButton
            // 
            ToDoButton.Location = new Point(54, 73);
            ToDoButton.Name = "ToDoButton";
            ToDoButton.Size = new Size(158, 23);
            ToDoButton.TabIndex = 1;
            ToDoButton.Text = "ToDo";
            ToDoButton.UseVisualStyleBackColor = true;
            ToDoButton.Click += Button1_Click;
            // 
            // UserSearchButton
            // 
            UserSearchButton.Location = new Point(54, 134);
            UserSearchButton.Name = "UserSearchButton";
            UserSearchButton.Size = new Size(158, 23);
            UserSearchButton.TabIndex = 2;
            UserSearchButton.Text = "ユーザー検索";
            UserSearchButton.UseVisualStyleBackColor = true;
            UserSearchButton.Click += Button2_Click;
            // 
            // UserRegistrationButton
            // 
            UserRegistrationButton.Location = new Point(54, 196);
            UserRegistrationButton.Name = "UserRegistrationButton";
            UserRegistrationButton.Size = new Size(158, 23);
            UserRegistrationButton.TabIndex = 3;
            UserRegistrationButton.Text = "ユーザー新規登録";
            UserRegistrationButton.UseVisualStyleBackColor = true;
            UserRegistrationButton.Click += Button3_Click;
            // 
            // ShopSearchButton
            // 
            ShopSearchButton.Location = new Point(54, 255);
            ShopSearchButton.Name = "ShopSearchButton";
            ShopSearchButton.Size = new Size(158, 23);
            ShopSearchButton.TabIndex = 4;
            ShopSearchButton.Text = "店舗検索";
            ShopSearchButton.UseVisualStyleBackColor = true;
            ShopSearchButton.Click += Button4_Click;
            // 
            // ShopRegistrationButton
            // 
            ShopRegistrationButton.Location = new Point(54, 313);
            ShopRegistrationButton.Name = "ShopRegistrationButton";
            ShopRegistrationButton.Size = new Size(158, 23);
            ShopRegistrationButton.TabIndex = 5;
            ShopRegistrationButton.Text = "店舗新規登録";
            ShopRegistrationButton.UseVisualStyleBackColor = true;
            ShopRegistrationButton.Click += Button5_Click;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Location = new Point(709, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(38, 15);
            Label1.TabIndex = 6;
            Label1.Text = "label1";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label1);
            Controls.Add(ShopRegistrationButton);
            Controls.Add(ShopSearchButton);
            Controls.Add(UserRegistrationButton);
            Controls.Add(UserSearchButton);
            Controls.Add(ToDoButton);
            Controls.Add(DataGridView1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView1;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn toDo;
        private Button ToDoButton;
        private Button UserSearchButton;
        private Button UserRegistrationButton;
        private Button ShopSearchButton;
        private Button ShopRegistrationButton;
        private Label Label1;
    }
}