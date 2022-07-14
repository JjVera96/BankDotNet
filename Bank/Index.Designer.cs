namespace Bank
{
    partial class Index
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.MyBalanceButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.RetireButton = new System.Windows.Forms.Button();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.HistoricalListView = new System.Windows.Forms.ListView();
            this.DateHeader = new System.Windows.Forms.ColumnHeader();
            this.MovementHeader = new System.Windows.Forms.ColumnHeader();
            this.AmountHeader = new System.Windows.Forms.ColumnHeader();
            this.AccountHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(12, 12);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(501, 40);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Bank";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.UseMnemonic = false;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddUserButton.Location = new System.Drawing.Point(408, 58);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(105, 36);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Users";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // MyBalanceButton
            // 
            this.MyBalanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyBalanceButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MyBalanceButton.Location = new System.Drawing.Point(12, 58);
            this.MyBalanceButton.Name = "MyBalanceButton";
            this.MyBalanceButton.Size = new System.Drawing.Size(122, 36);
            this.MyBalanceButton.TabIndex = 3;
            this.MyBalanceButton.Text = "My Balance";
            this.MyBalanceButton.UseVisualStyleBackColor = true;
            this.MyBalanceButton.Click += new System.EventHandler(this.MyBalanceButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferButton.Location = new System.Drawing.Point(12, 100);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(122, 36);
            this.TransferButton.TabIndex = 4;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // RetireButton
            // 
            this.RetireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RetireButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RetireButton.Location = new System.Drawing.Point(12, 142);
            this.RetireButton.Name = "RetireButton";
            this.RetireButton.Size = new System.Drawing.Size(122, 36);
            this.RetireButton.TabIndex = 5;
            this.RetireButton.Text = "Retire";
            this.RetireButton.UseVisualStyleBackColor = true;
            this.RetireButton.Click += new System.EventHandler(this.RetireButton_Click);
            // 
            // IncomeButton
            // 
            this.IncomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncomeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomeButton.Location = new System.Drawing.Point(12, 184);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(122, 36);
            this.IncomeButton.TabIndex = 6;
            this.IncomeButton.Text = "Income";
            this.IncomeButton.UseVisualStyleBackColor = true;
            this.IncomeButton.Click += new System.EventHandler(this.IncomeButton_Click);
            // 
            // HistoricalListView
            // 
            this.HistoricalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateHeader,
            this.MovementHeader,
            this.AmountHeader,
            this.AccountHeader});
            this.HistoricalListView.Location = new System.Drawing.Point(13, 226);
            this.HistoricalListView.Name = "HistoricalListView";
            this.HistoricalListView.Size = new System.Drawing.Size(500, 212);
            this.HistoricalListView.TabIndex = 8;
            this.HistoricalListView.UseCompatibleStateImageBehavior = false;
            this.HistoricalListView.View = System.Windows.Forms.View.Details;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Date";
            this.DateHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateHeader.Width = 120;
            // 
            // MovementHeader
            // 
            this.MovementHeader.Text = "Movement";
            this.MovementHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MovementHeader.Width = 120;
            // 
            // AmountHeader
            // 
            this.AmountHeader.Text = "Amount";
            this.AmountHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountHeader.Width = 120;
            // 
            // AccountHeader
            // 
            this.AccountHeader.Text = "Account";
            this.AccountHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AccountHeader.Width = 119;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.HistoricalListView);
            this.Controls.Add(this.IncomeButton);
            this.Controls.Add(this.RetireButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.MyBalanceButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Index_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Label TitleLabel;
        private Button AddUserButton;
        private Button MyBalanceButton;
        private Button TransferButton;
        private Button RetireButton;
        private Button IncomeButton;
        private ListView HistoricalListView;
        private ColumnHeader MovementHeader;
        private ColumnHeader AmountHeader;
        private ColumnHeader AccountHeader;
        private ColumnHeader DateHeader;
    }
}