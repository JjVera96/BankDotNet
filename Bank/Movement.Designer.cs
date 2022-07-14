namespace Bank
{
    partial class Movement
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.MovementLabel = new System.Windows.Forms.Label();
            this.PersonLabel = new System.Windows.Forms.Label();
            this.PersonBox = new System.Windows.Forms.TextBox();
            this.RealizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(12, 55);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(83, 28);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount";
            // 
            // AmountBox
            // 
            this.AmountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountBox.Location = new System.Drawing.Point(12, 86);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(99, 23);
            this.AmountBox.TabIndex = 5;
            // 
            // MovementLabel
            // 
            this.MovementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovementLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovementLabel.Location = new System.Drawing.Point(12, 12);
            this.MovementLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MovementLabel.Name = "MovementLabel";
            this.MovementLabel.Size = new System.Drawing.Size(381, 40);
            this.MovementLabel.TabIndex = 4;
            this.MovementLabel.Text = "Movement";
            this.MovementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MovementLabel.UseMnemonic = false;
            // 
            // PersonLabel
            // 
            this.PersonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonLabel.Location = new System.Drawing.Point(12, 112);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(70, 28);
            this.PersonLabel.TabIndex = 8;
            this.PersonLabel.Text = "Person";
            this.PersonLabel.Visible = false;
            // 
            // PersonBox
            // 
            this.PersonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonBox.Location = new System.Drawing.Point(12, 143);
            this.PersonBox.Name = "PersonBox";
            this.PersonBox.Size = new System.Drawing.Size(99, 23);
            this.PersonBox.TabIndex = 7;
            this.PersonBox.Visible = false;
            // 
            // RealizeButton
            // 
            this.RealizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RealizeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RealizeButton.Location = new System.Drawing.Point(293, 167);
            this.RealizeButton.Name = "RealizeButton";
            this.RealizeButton.Size = new System.Drawing.Size(100, 36);
            this.RealizeButton.TabIndex = 9;
            this.RealizeButton.Text = "Realize";
            this.RealizeButton.UseVisualStyleBackColor = true;
            this.RealizeButton.Click += new System.EventHandler(this.RealizeButton_Click);
            // 
            // Movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 235);
            this.Controls.Add(this.RealizeButton);
            this.Controls.Add(this.PersonLabel);
            this.Controls.Add(this.PersonBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.MovementLabel);
            this.Name = "Movement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AmountLabel;
        private TextBox AmountBox;
        private Label MovementLabel;
        private Label PersonLabel;
        private TextBox PersonBox;
        private Button RealizeButton;
    }
}