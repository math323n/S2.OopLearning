using System;
using System.Collections.Generic;
using System.Text;

namespace S2.OopUmletDiagram
{
    public class ContactInformation
    {
        private int id;
        private string email;
        private string phoneNumber;

        public ContactInformation()
        {

        }

        public int Id
        {
            get => id;
            set
            {
                if(value != id)
                {
                    id = value;
                }
            }
        }
        public string Email        {
            get => email;
            set
            {
                if(value != email)
                {
                    email = value;
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if(value != phoneNumber)
                {
                    phoneNumber = value;
                }
            }
        }
     



    }
}
