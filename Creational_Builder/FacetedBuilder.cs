using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder
{
    public class Person
    {
        public string StreetAddress, Postcode, City;

        public string CompanyName, Position;
        public int AnnualIncome;

        public override string? ToString()
        {
            return StreetAddress + Postcode + City + CompanyName + this.Position + AnnualIncome.ToString();
        }
    }

    public class PersonBuilder
    {
        protected Person person = new Person();
        public PersonjobBuilder Works => new PersonjobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person); 
        public static implicit operator Person(PersonBuilder builder)
        {
            return builder.person;
        }
    }

    public class PersonjobBuilder : PersonBuilder
    {
        public PersonjobBuilder(Person person)
        {
            this.person = person;
        }
        public PersonjobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }
        public PersonjobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        } 
    }

    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.StreetAddress = streetAddress;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
        public PersonAddressBuilder WithPostalCode(string postalCode)
        {
            person.Postcode = postalCode;
            return this;
        }
    }
}
