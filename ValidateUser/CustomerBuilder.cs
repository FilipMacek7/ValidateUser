using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidateUser
{
    public class CustomerBuilder
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
        public DateTime BirthDate { get; set; }

        public CustomerBuilder WithSurName(string surname)
        {
            this.Surname = surname;
            return this;
        }

        public CustomerBuilder WithForeName(string forename)
        {
            this.Forename = forename;
            return this;
        }
        public CustomerBuilder WithBirthDate(DateTime birthdate)
        {
            this.BirthDate = birthdate;
            return this;
        }
    }
}
