using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
    
    public partial class Form1 : Form
    {

        private List<Osoba> contacts = new List<Osoba>();
        string messageError = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddNewContact();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        public void EditContact()
        {
            int index = ContactList.SelectedIndex;
            if (index > -1)
            {
                if (ValidateEditFieldsContacts())
                {
                    ChangeInformationInContact(index);
                    MessageBox.Show("Dane kontaktu zostały zmienione pomyślnie.", "Komunikat");   
                } 
                else
                {
                    MessageBox.Show(messageError, "Błąd wprowadzanych danych");
                    messageError = "";
                }  
            }
            else
            {
                MessageBox.Show("Wyznacz rekord którego dane chcesz zmienić.", "Komunikat");
            }
        }

        private void ChangeInformationInContact(int index)
        {
            contacts.ElementAt(index).Name = NameEdit.Text;
            contacts.ElementAt(index).Surname = SurnameEdit.Text;
            contacts.ElementAt(index).PhoneNumber = PhoneEdit.Text;
            ContactList.SelectedItem = NameEdit.Text + " " + SurnameEdit.Text;
        }

        private void AddNewContact()
        {

            Osoba osoba = CreateNewContact();
            if (osoba != null)
            {
                contacts.Add(osoba);
                ContactList.Items.Add(osoba.Name + " " + osoba.Surname);
                ClearAddFields();
            }
            else
            {
                MessageBox.Show(messageError, "Błąd w wprowadzaniu danych");
                messageError = "";
            }
        }

        private Osoba CreateNewContact()
        {

            Osoba osoba = null;

            if (ValidateAddFieldsContacts())
            {
                string name = NameAdd.Text;
                string surname = SurnameAdd.Text;

                int dayOfBorn = int.Parse(DayOfBornAdd.Text);
                int monthOfBorn = int.Parse(MonthOfBornAdd.Text);
                int yearOfBorn = int.Parse(YearOfBornAdd.Text);

                osoba = new Osoba(name, surname, dayOfBorn, monthOfBorn, yearOfBorn);
            }
            
            return osoba;

        }

        private bool ValidateAddFieldsContacts()
        {
            bool isCorrect = true;

            List<bool> matches = new List<bool>();

            isCorrect = CheckCorrectName(NameAdd.Text);
            matches.Add(isCorrect);

            isCorrect = CheckCorrectSurname(SurnameAdd.Text);
            matches.Add(isCorrect);

            isCorrect = CheckCorrectOfDay(DayOfBornAdd.Text);
            matches.Add(isCorrect);

            isCorrect = CheckCorrectOfMonth(MonthOfBornAdd.Text);
            matches.Add(isCorrect);

            isCorrect = ChcekCorrectOfYear(YearOfBornAdd.Text);
            matches.Add(isCorrect);

            if (matches.Contains(false))
            {
                isCorrect = false;
            }

            if (isCorrect)
            {
                isCorrect = ValidateDate(DayOfBornAdd.Text, MonthOfBornAdd.Text, YearOfBornAdd.Text);
                if (!isCorrect)
                {
                    messageError += "Taka data jeszcze nie wystąpiła. Zbyt późny dzień albo miesiąc.";
                }
            }

            return isCorrect;
        }

        private bool ValidateEditFieldsContacts()
        {
            bool isCorrect = true;

            List<bool> matches = new List<bool>();

            isCorrect = CheckCorrectName(NameEdit.Text);
            matches.Add(isCorrect);

            isCorrect = CheckCorrectSurname(SurnameEdit.Text);
            matches.Add(isCorrect);

            isCorrect = CheckCorrectPhoneNumber(PhoneEdit.Text);
            matches.Add(isCorrect);

            if (matches.Contains(false))
            {
                isCorrect = false;

            }

            return isCorrect;
        }

        private bool CheckCorrectName(String text)
        {
            bool isCorrect = true;
            isCorrect = CheckCorrectText(text);
            if (!isCorrect)
            {
                messageError += "Nie poprawny format imienia.  \n";
            }

            return isCorrect;
        }

        private bool CheckCorrectSurname(String text)
        {
            bool isCorrect = true;
            isCorrect = CheckCorrectText(text);
            if (!isCorrect)
            {
                messageError += "Nie poprawny format nazwiska. \n";
            }

            return isCorrect;
        }


        private bool CheckCorrectText(String text)
        {
            bool isCorrect = true;
            Match match = Regex.Match(text, @"^[\s\p{L}]+$");
            if (!match.Success)
            {
                isCorrect = false;
            }

            return isCorrect;
        }

        private bool CheckCorrectPhoneNumber(String text)
        {
            bool isCorrect = true;
            if (!CheckCorrectOfNumbers(text))
            {
                isCorrect = false;
                messageError += "Nieprawidłowy numer telefonu. \n";
            }

            return isCorrect;
        }

        private bool CheckCorrectOfDay(String text)
        {
            bool isCorrect = true;

            if (CheckCorrectOfNumbers(text))
            {
                int day = Int32.Parse(text);
                if (day < 1 || day > 31)
                {
                    isCorrect = false;
                }
            }
            else
            {
                isCorrect = false;
            }

            if (!isCorrect)
            {
                messageError += "Nie poprawny format dnia, badź zawyżona wartość. \n";
            }

            return isCorrect;
        }

        private bool CheckCorrectOfMonth(String text)
        {
            bool isCorrect = true;

            if (CheckCorrectOfNumbers(text))
            {
                int month = Int32.Parse(text);
                if (month < 1 || month > 12)
                {
                    isCorrect = false;
                }
            }
            else
            {
                isCorrect = false;
            }

            if (!isCorrect)
            {
                messageError += "Nie poprawny format miesiąca, badź zawyżona wartość. \n";
            }

            return isCorrect;
        }

        private bool ChcekCorrectOfYear(String text)
        {
            bool isCorrect = true;

            if (CheckCorrectOfNumbers(text))
            {
                int year = Int32.Parse(text);
                if (year > DateTime.Now.Year)
                {
                     
                    isCorrect = false;
                }
            }
            else
            {
                isCorrect = false;
            }

            if (!isCorrect)
            {
                messageError += "Nie poprawny format roku, badź zawyżona wartość. \n";
            }

            return isCorrect;
        }

        private bool CheckCorrectOfNumbers(String text)
        {
            bool isCorrect = true;
            Match match = Regex.Match(text, "^[0-9]+$");
            if (!match.Success)
            {
                isCorrect = false;
            }
            

            return isCorrect;
        }


        private bool ValidateDate(string day, string month, string year)
        {
            bool isCorrect = true;

            int dayS = Int32.Parse(day);
            int monthS = int.Parse(month);
            int yearS = int.Parse(year);

            if (yearS == DateTime.Now.Year)
            {
                if (monthS > DateTime.Now.Month)
                {
                    isCorrect = false;
                }

                if (isCorrect && dayS > DateTime.Now.Day)
                {
                    isCorrect = false;
                }
            } 
            
        
            return isCorrect; 
        }

        private void ContactList_Click(object sender, EventArgs e)
        {
            PutInformationToEditFields();
        }

        public void PutInformationToEditFields()
        {
            int index = ContactList.SelectedIndex;
            if (index > - 1)
            {
                Osoba osoba = contacts.ElementAt(index);

                NameEdit.Text = osoba.Name;
                SurnameEdit.Text = osoba.Surname;
                DayOfBornEdit.Text = osoba.DayOFBorn.ToString();
                MonthOfBornEdit.Text = osoba.MonthOFBorn.ToString();
                YearOfBornEdit.Text = osoba.YearOFBorn.ToString();

                if (osoba.PhoneNumber != null)
                {
                    PhoneEdit.Text = osoba.PhoneNumber;
                }
                else
                {
                    PhoneEdit.Text = "";
                }
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        private void DeleteContact()
        {
            int index = ContactList.SelectedIndex;
            if (index > -1)
            {
                DialogResult result = MessageBox.Show("Czy napewno chesz usunąć wybrany kontakt?",
                    "Usunięcie kontaktu", MessageBoxButtons.YesNo);

                if (result.ToString() == "Yes") {
                    contacts.RemoveAt(index);
                    ContactList.Items.RemoveAt(index);
                    ClearEditFields();
                }
            }
            else
            {
                MessageBox.Show("Najpierw wyznacz element do usunięcia", "Komunikat");
            }
        }

        private void ClearAddFields()
        {
            NameAdd.Text = "";
            SurnameAdd.Text = "";
            DayOfBornAdd.Text = "";
            MonthOfBornAdd.Text = "";
            YearOfBornAdd.Text = "";
        }


        private void ClearEditFields()
        {
            NameEdit.Text = "";
            SurnameEdit.Text = "";
            PhoneEdit.Text = "";
            DayOfBornEdit.Text = "";
            MonthOfBornEdit.Text = "";
            YearOfBornEdit.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
