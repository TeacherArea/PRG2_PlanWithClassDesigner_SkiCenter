using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiCenter
{
    public class Person
    {
        private int id;
        private string? name;
        private string? email;
        private string? phoneNumber;

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0) throw new ArgumentException("Id måste vara större än 0.");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Namn kan inte vara tomt.");
                name = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!value.Contains("@")) throw new ArgumentException("E-postadressen måste innehålla '@'.");
                email = value;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length != 10) throw new ArgumentException("Telefonnummer måste ha 10 siffror."); //Exempel för svenska nummer
                phoneNumber = value;
            }
        }
    }
}