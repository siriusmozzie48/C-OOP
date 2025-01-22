namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

            //BankAccount bankAccount = new BankAccount("Abdul Moiz");
            //bankAccount.Owner = "Abdul Moiz";
            //bankAccount.AccountNumber = Guid.NewGuid();
            //bankAccount.Balance = 250;

            //BankAccount bankAccount2 = new BankAccount("Elon Musk");
            //bankAccount2.Owner = "Elon Musk";
            //bankAccount2.AccountNumber = Guid.NewGuid();
            //bankAccount2.Balance = 9999;

            //BankAccount bankAccount3 = new BankAccount("Bill Gates");
            //bankAccount3.Owner = "Bill Gates";
            //bankAccount3.AccountNumber = Guid.NewGuid();
            //bankAccount3.Balance = 150;

            //List<BankAccount> bankAccounts = new List<BankAccount>();
            //bankAccounts.Add(bankAccount);
            //bankAccounts.Add(bankAccount2);
            //bankAccounts.Add(bankAccount3);

            //BankAccountsGrid.DataSource = bankAccounts;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OwnerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text)) return;
            if (InterestRateNum.Value > 0)
            {
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestRateNum.Value));
            }
            else
            {
                //BankAccount bankAccount = new BankAccount(OwnerTxt.Text);

                /*if (bankAccount.Owner != "")*/
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));

            }
            //BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            
            /*if (bankAccount.Owner != "")*/
            //BankAccounts.Add(bankAccount);

            RefreshGrid();
            OwnerTxt.Text = "";
            InterestRateNum.Value = 0;




        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1/* && AmountNum.Value > 0*/)
            {
                BankAccount seletedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                //seletedBankAccount.Balance += AmountNum.Value;
                string message = seletedBankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);

            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 /*&& AmountNum.Value > 0*/)
            {
                BankAccount seletedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = seletedBankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BankAccountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
