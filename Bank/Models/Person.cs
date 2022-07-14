using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Person
    {
        private static readonly string RouteTxtUserFile = "users.txt";
        private string RouteTxtHistorial { get; set; }
        private string DNI { get; set; }
        private string Name { get; set; }
        private string Lastname { get; set; }
        private string Password { get; set; }
        private double Balance { get; set; }
        private bool IsAdmin { get; set; } 

        public Person(string line)
        {
            string[] fields = line.Split(",");
            DNI = fields[0];
            Name = fields[1];
            Lastname = fields[2];
            Password = fields[3];
            IsAdmin = Convert.ToBoolean(fields[4]);
            RouteTxtHistorial = $"{DNI}-Historial.txt";
            ReadBalance();
        }

        public Person(
            string dni, 
            string name, 
            string lastname, 
            string password, 
            double balance,
            bool isAdmin
            )
        {
            DNI = dni;
            Name = name;
            Lastname = lastname;
            Password = password;
            Balance = balance;
            IsAdmin = isAdmin;
            RouteTxtHistorial = $"{DNI}-Historial.txt";
        }

        public void ReadBalance()
        {
            if (File.Exists(RouteTxtHistorial)) {
                string[] lines = File.ReadAllLines(RouteTxtHistorial);
                if (lines.Length > 0) {
                    string line = lines.Last();
                    string[] fields = line.Split(',');
                    Balance = Convert.ToDouble(fields[4]);
                }
                else Balance = 0;
            }
            else
            {
                Balance = 0;
                File.Create(RouteTxtHistorial).Close();
            }
        }

        private void UpdateHistorialFile(string type, double amount, Person? person)
        {
            StreamWriter sw = new(RouteTxtHistorial, append: true);
            string account = (person != null) ? 
                $"{person.GetPublicName()}" : 
                "";
            sw.WriteLine($"{DateTime.Now},{type},{account},{amount},{Balance}");
            sw.Close();
        }

        public string GetPublicName()
        {
            if (!IsAdmin) return $"{GetDNI()} ({GetFullName()})";
            return "Unknown";
        }

        public string GetDNI()
        {
            return DNI;
        }

        public string GetBalance()
        {
            return Balance.ToString("C");
        }

        public List<(DateTime, string, string, double)> GetHistorical()
        {
            List<(DateTime, string, string, double)> historical = new();
            if (File.Exists(RouteTxtHistorial))
            {
                StreamReader sr = new(RouteTxtHistorial);
                while (!sr.EndOfStream)
                {
                    string line = new(sr.ReadLine());
                    string[] fields = line.Split(",");
                    var values = (DateTime.Parse(fields[0]), fields[1], fields[2], Convert.ToDouble(fields[3]));
                    historical.Add(values);
                }
                sr.Close();
            }
            return historical;
        }

        public string GetFullName()
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return $"{ti.ToTitleCase(Name)} {ti.ToTitleCase(Lastname)}";
        }

        public bool GetIsAdmin()
        {
            return IsAdmin;
        }

        public bool IsLoginValid(string password)
        {
            if (Password != password) return false;
            return true;
        }

        public bool HasBalance(double amount)
        {
            if (Balance >= amount) return true;
            return false;
        }

        public void AddAmount(double amount, string type, Person? person)
        {
            Balance += amount;
            UpdateHistorialFile(type, amount, person);
        }

        public void RetireAmount(double amount, string type, Person? person)
        {
            if (HasBalance(amount))
            {
                Balance -= amount;
                UpdateHistorialFile(type, amount, person);
            }
        }

        public void TransferAmount(double amount, Person person)
        {
            if (HasBalance(amount))
            {
                RetireAmount(amount, "Transfer To", person);
                person.AddAmount(amount, "Transfer From", this);
            }
        }

        public string Str()
        {
            return $"{DNI},{Name.ToLower()},{Lastname.ToLower()},{Password},{IsAdmin}";
        }

        public static void ChecksUserFile()
        {
            if (!File.Exists(RouteTxtUserFile))
            {
                CreateAdmin();
            }
        }

        public static void CreatePerson(
            string dni,
            string name,
            string lastname,
            string password,
            double balance,
            bool isAdmin
            )
        {
            Person person = new(dni, name, lastname, password, balance, isAdmin);
            StreamWriter sw = new(RouteTxtUserFile, append: true);
            sw.WriteLine(person.Str());
            sw.Close();
            person.UpdateHistorialFile("Create Account", balance, null);
        }

        public static void CreateAdmin()
        {
            CreatePerson("Admin", "Admin", "Admin", "Admin", 0, true);
        }

        public static Tuple<bool, Person?> SearchUser(string dni)
        {
            bool isFound = false;
            Person? user = null;
            StreamReader sr = new(RouteTxtUserFile);
            while (!sr.EndOfStream)
            {
                string line = new(sr.ReadLine());
                string[] fields = line.Split(",");
                if (fields[0] == dni)
                {
                    isFound = true;
                    user = new Person(line);
                    break;
                }
            }
            sr.Close();
            return new(isFound, user);
        }

        public static List<(string, string, string)> GetPersons()
        {
            List<(string, string, string)> persons = new();
            StreamReader sr = new(RouteTxtUserFile);
            while (!sr.EndOfStream)
            {
                string line = new(sr.ReadLine());
                string[] fields = line.Split(",");
                persons.Add((fields[0], fields[1], fields[2]));
            }
            sr.Close();
        return persons;
        }
    }
}
