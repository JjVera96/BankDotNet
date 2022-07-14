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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            GetUsers();
        }

        private Tuple<bool, string> ValidateFields()
        {
            string errorMessage = string.Empty;
            bool result = true;
            if (NameBox.Text == string.Empty || LastnameBox.Text == string.Empty ||
                DNIBox.Text == string.Empty || BalanceBox.Text == string.Empty ||
                PasswordBox.Text == string.Empty)
            {
                errorMessage = "Some fields are empty.";
                result = false;
            }
            else if (!Regex.IsMatch(BalanceBox.Text, @"^[\d\.]+$"))
            {
                errorMessage = "Balance must be only numbers.";
                result = false;
            }
            return new(result, errorMessage);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> validatedData = ValidateFields();
            if (validatedData.Item1)
            {
                if (Person.SearchUser(DNIBox.Text.ToLower()).Item1)
                {
                    MessageBox.Show("User with DNI already exists.");
                }
                else
                {
                    Person.CreatePerson(
                        DNIBox.Text,
                        NameBox.Text,
                        LastnameBox.Text,
                        PasswordBox.Text,
                        Convert.ToDouble(BalanceBox.Text),
                        false);
                    MessageBox.Show("User saved successfully");
                    CleanBoxes();
                    GetUsers();
                }
            }
            else
            {
                MessageBox.Show(validatedData.Item2);
            }
        }

        private void CleanBoxes()
        {
            DNIBox.Text = string.Empty; 
            NameBox.Text = string.Empty;
            LastnameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
            BalanceBox.Text = string.Empty;
        }

        private void GetUsers()
        {
            List<(string, string, string)> users = Person.GetPersons();
            UserListView.Items.Clear();
            foreach(var item in users)
            {
                ListViewItem list = new (item.Item1.ToString());
                list.SubItems.Add(item.Item2);
                list.SubItems.Add(item.Item3);
                UserListView.Items.Add(list);
            }
        }
    }
}