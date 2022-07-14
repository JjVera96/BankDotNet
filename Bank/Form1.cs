using Bank.Models;

namespace Bank
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Person.ChecksUserFile();
        }

        private Tuple<bool, string> ValidateFields()
        {
            string errorMessage = string.Empty;
            bool result = true;
            if (DNIBox.Text == string.Empty || PasswordBox.Text == string.Empty)
            {
                errorMessage = "Some fields are empty.";
                result = false;
            }
            return new(result, errorMessage);
        }

        private void CleanFields()
        {
            DNIBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> validatedData = ValidateFields();
            if (validatedData.Item1)
            {
                Tuple<bool, Person?> validatedUser = Person.SearchUser(DNIBox.Text);
                if (validatedUser.Item1)
                {
                    ArgumentNullException.ThrowIfNull(validatedUser.Item2);
                    Person user = validatedUser.Item2;
                    if (user.IsLoginValid(PasswordBox.Text))
                    {
                        CleanFields();
                        var Index = new Index(ref user, this);
                        Index.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("User does not found.");
                }
            }
            else
            {
                MessageBox.Show(validatedData.Item2);
            }
        }
    }
}