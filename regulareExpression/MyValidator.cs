using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regulareExpression
{
    public class MyValidator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public int PostalCity { get; set; }
        public int PostalCode { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }



        public void FirstNameValidate()
        {

            String pattern = @"\D+"; 
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(FirstName))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is invalid");
            }        


        }

        public void LastNameValidate()
        {
            String pattern = @"\D+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(LastName))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is invalid");
            }
        }

        public void StreetValidate()
        {
            String pattern = @"\D+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(Street))
            {
                Console.WriteLine("Street is valid");
            }
            else
            {
                Console.WriteLine("Street is invalid");
            }
        }

        public void PostalCityValidate()
        {
            String pattern = @"\D+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(PostalCity.ToString()))
            {
                Console.WriteLine("Postal City is valid");
            }
            else
            {
                Console.WriteLine("Postal City is invalid");
            }
        }

        public void PostalCodeValidate()
        {
            String pattern = @"\d{4}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(PostalCode.ToString()))
            {
                Console.WriteLine("Postal Code is valid");
            }
            else
            {
                Console.WriteLine("Postal Code is invalid");
            }
        }

        public void NumberValidate()
        {
            String pattern = @"\d{1,3}[a-z]{1}\d{1}}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(Number.ToString()))
            {
                Console.WriteLine("Number is valid");
            }
            else
            {
                Console.WriteLine("Number is invalid");
            }
        }

        public void PhoneValidate() { 
        
        String pattern = @"^\+45\d{8}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(Phone))
            {
                Console.WriteLine("Phone is valid");
            }
            else
            {
                Console.WriteLine("Phone is invalid");
            }


        }
        public void EmailValidate()
        {
            String pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(Email))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is invalid");
            }
        }
    }
}
