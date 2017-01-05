using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    class Osoba
    {
        private String surname;
        private DateTime bornDate;
        private String phoneNumber;

        public Osoba(String name, String surname, int dayOfBorn, int monthOfBorn, int yearOfMonth)
        {
            this.Name = name;
            this.surname = surname;

            bornDate = new DateTime(yearOfMonth, monthOfBorn, dayOfBorn);

        }

        // properties

        public String Name { get; set; }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int DayOFBorn
        {
            get { return bornDate.Day;  }
        }

        public int MonthOFBorn
        { 
            get { return bornDate.Month; }
        }

        public int YearOFBorn
        {
            get { return bornDate.Year; }
        }

        public String PhoneNumber
        {
            get { return phoneNumber;  }
            set { phoneNumber = value; }
        }


    }
}
