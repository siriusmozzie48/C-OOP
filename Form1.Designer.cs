﻿namespace BankAccountsApp
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 0;
            label1.Text = "Owner :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(2, 348);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 1;
            label2.Text = "Amount :";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(96, 62);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(160, 31);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += OwnerTxt_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(136, 349);
            AmountNum.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(218, 31);
            AmountNum.TabIndex = 5;
            AmountNum.ValueChanged += AmountNum_ValueChanged;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(387, 6);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 62;
            BankAccountsGrid.Size = new Size(417, 215);
            BankAccountsGrid.TabIndex = 6;
            BankAccountsGrid.CellContentClick += BankAccountsGrid_CellContentClick;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(409, 311);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(145, 34);
            DepositBtn.TabIndex = 7;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(622, 311);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(135, 34);
            WithdrawBtn.TabIndex = 8;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(96, 213);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(141, 38);
            CreateAccountBtn.TabIndex = 9;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 138);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 10;
            label3.Text = "Interest Rate(%):";
            label3.Click += label3_Click;
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(174, 139);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(180, 31);
            InterestRateNum.TabIndex = 11;
            InterestRateNum.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
