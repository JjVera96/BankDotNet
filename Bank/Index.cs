using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Models;

namespace Bank
{
    public partial class Index : Form
    {
        Person User;
        readonly Form Father;
        public Index(ref Person person, Form father)
        {
            InitializeComponent();
            User = person;
            TitleLabel.Text = $"User: {User.GetDNI()} - {User.GetFullName()}";
            AddUserButton.Enabled = User.GetIsAdmin();
            if (!User.GetIsAdmin()) AddUserButton.Hide();
            Father = father;
            Father.Hide();
            GetUserHistorical();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var AddUser = new AddUser();
            AddUser.Show();
        }

        private void MyBalanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your balance is {User.GetBalance()}");
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            var Movement = new Movement(ref User, "Transfer", this);
            Movement.Show();
        }

        private void RetireButton_Click(object sender, EventArgs e)
        {
            var Movement = new Movement(ref User, "Retire", this);
            Movement.Show();
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            var Movement = new Movement(ref User, "Income", this);
            Movement.Show();
        }

        private Color ColorLine(string movement)
        {
            if (movement == "Retire" || movement == "Transfer To") return Color.Red;
            if (movement == "Income" || movement == "Transfer From") return Color.Green;
            return Color.White;
        }

        public void GetUserHistorical()
        {
            List<(DateTime, string, string, double)> historical = User.GetHistorical();
            HistoricalListView.Items.Clear();
            foreach (var item in historical)
            {
                ListViewItem list = new ListViewItem(item.Item1.ToString());
                list.SubItems.Add(item.Item2);
                list.SubItems.Add(item.Item4.ToString("C"));
                list.SubItems.Add(item.Item3);
                list.BackColor = ColorLine(item.Item2);
                HistoricalListView.Items.Add(list);
            }
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Father.Show();
        }
    }
}
