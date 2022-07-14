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
using System.Text.RegularExpressions;

namespace Bank
{
    public partial class Movement : Form
    {
        readonly Person User;
        readonly string Type;
        readonly Index Father;
        public Movement(ref Person person, string type, Index father)
        {
            InitializeComponent();
            User = person;
            MovementLabel.Text = $"Movement: {type}";
            Type = type;
            if (Type == "Transfer")
            {
                PersonLabel.Visible = true;
                PersonBox.Visible = true;
            }
            Father = father;
        }

        private Tuple<bool, string> ValidateFields()
        {
            string errorMessage = string.Empty;
            bool result = true;
            if (AmountBox.Text == string.Empty ||
                (PersonBox.Text == string.Empty && Type == "Transfer"))
            {
                errorMessage = "Some fields are empty.";
                result = false;
            }
            else if (!Regex.IsMatch(AmountBox.Text, @"^[\d\.]+$") ||
                Convert.ToDouble(AmountBox.Text) <= 0)
            {
                errorMessage = "Amount must be only positive numbers.";
                result = false;
            } 
            else if(PersonBox.Text == User.GetDNI())
            {
                errorMessage = "DNI must be different from yours.";
                result = false;
            }
            return new(result, errorMessage);
        }

        private void RealizeButton_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> validatedData = ValidateFields();
            if (validatedData.Item1)
            {
                double amount = Convert.ToDouble(AmountBox.Text);
                if (Type == "Income")
                {
                    User.AddAmount(amount, "Income", null);
                    MessageBox.Show("Movement realized");
                    this.Close();
                }
                if (Type == "Retire")
                {
                    if (User.HasBalance(amount))
                    {
                        User.RetireAmount(amount, "Retire", null);
                        MessageBox.Show("Movement realized");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No balance");
                        this.Close();
                    }
                }
                if (Type == "Transfer")
                {
                    if (User.HasBalance(amount))
                    {
                        Tuple<bool, Person?> validatedUser = Person.SearchUser(PersonBox.Text);
                        if (validatedUser.Item1)
                        {
                            ArgumentNullException.ThrowIfNull(validatedUser.Item2);
                            User.TransferAmount(amount, validatedUser.Item2);
                            MessageBox.Show("Movement realized");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No balance");
                        this.Close();
                    }
                }
                Father.GetUserHistorical();
            }
            else
            {
                MessageBox.Show(validatedData.Item2);
            }
        }
    }
}
