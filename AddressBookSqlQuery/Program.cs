
using AddressBookSqlQuery;
using System;
using System.Net;

namespace AddressBookSqlQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact details = new Contact()
            {
                firstname = "Rithika",
                lastname = "Logachandran",
                address = "Madhavaram",
                city = "Chennai",
                state = "TamilNadu",
                zip = 600051,
                phonenumber = "9789286965",
                email = "rithi@gmail.com"
            };
            Operation operation = new Operation();
            operation.AddContactDetails(details);
            //Contact contact1 = new Contact()
            //{
            //    firstname = "Rithika L",
            //    lastname = "Logachandran",
            //    address = "Madhavaram",
            //    city = "Chennai",
            //    state = "TamilNadu",
            //    zip = 600051,
            //    phonenumber = "9789286965",
            //    email = "rithi@gmail.com"
            //};
            //operation.EditContactDetails(contact1);
            //operation.DeleteContactDetails("Rithika");
            //operation.DetailsInCity("Chennai");
            //operation.DetailsinState("TamilNadu");
            //operation.CountInCity();
            //operation.CountInState();
        }
    }
}
