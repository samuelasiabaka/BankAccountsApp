namespace BankAccountsApp
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
            OwnerLabel = new Label();
            AmountLabel = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            CreateAccountBtn = new Button();
            WithrawBtn = new Button();
            DepositBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // OwnerLabel
            // 
            OwnerLabel.AutoSize = true;
            OwnerLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OwnerLabel.Location = new Point(24, 51);
            OwnerLabel.Name = "OwnerLabel";
            OwnerLabel.Size = new Size(105, 38);
            OwnerLabel.TabIndex = 0;
            OwnerLabel.Text = "Owner:";
            OwnerLabel.Click += label1_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLabel.Location = new Point(24, 355);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(122, 38);
            AmountLabel.TabIndex = 1;
            AmountLabel.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OwnerTxt.Location = new Point(135, 51);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(200, 38);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountNum.Location = new Point(152, 354);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(183, 38);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(386, 46);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(634, 290);
            BankAccountsGrid.TabIndex = 4;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(135, 110);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(178, 41);
            CreateAccountBtn.TabIndex = 5;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // WithrawBtn
            // 
            WithrawBtn.Location = new Point(725, 356);
            WithrawBtn.Name = "WithrawBtn";
            WithrawBtn.Size = new Size(178, 41);
            WithrawBtn.TabIndex = 6;
            WithrawBtn.Text = "Withdraw";
            WithrawBtn.UseVisualStyleBackColor = true;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(440, 355);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(178, 41);
            DepositBtn.TabIndex = 7;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 450);
            Controls.Add(DepositBtn);
            Controls.Add(WithrawBtn);
            Controls.Add(CreateAccountBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(AmountLabel);
            Controls.Add(OwnerLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OwnerLabel;
        private Label AmountLabel;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button CreateAccountBtn;
        private Button WithrawBtn;
        private Button DepositBtn;
    }
}
