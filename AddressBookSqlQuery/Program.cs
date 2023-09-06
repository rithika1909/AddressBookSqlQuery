
using AddressBookSqlQuery;
using System;
using System.Net;

namespace AddressBookSqlQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contact details = new Contact()
            //{
            //    firstname = "Rithika",
            //    lastname = "Logachandran",
            //    address = "Madhavaram",
            //    city = "Chennai",
            //    state = "TamilNadu",
            //    zip = 600051,
            //    phonenumber = "9789286965",
            //    email = "rithi@gmail.com"
            //};
            //Contact details1 = new Contact()
            //{
            //    firstname = "Riya",
            //    lastname = "Reji",
            //    address = "Anna nagar",
            //    city = "Chennai",
            //    state = "TamilNadu",
            //    zip = 600064,
            //    phonenumber = "8976543675",
            //    email = "riya@gmail.com"

            //};
            Operation operation = new Operation();
            //operation.AddContactDetails(details);
            //operation.AddContactDetails(details1);
            //Contact contact1 = new Contact()
            //{
            //    firstname = "Rithika ",
            //    lastname = "L",
            //    address = "Madhavaram",
            //    city = "Chennai",
            //    state = "TamilNadu",
            //    zip = 600051,
            //    phonenumber = "9789286965",
            //    email = "rithi@gmail.com"
            //};
            //operation.EditContactDetails(contact1);
            //operation.DeleteContactDetails("Rithika");
            //operation.DeleteContactDetails("Riya");
            //operation.DetailsInCity("Chennai");
            //operation.DetailsinState("TamilNadu");
            //operation.CountInCity();
            //operation.CountInState();
            //operation.CountByType();
            //operation.CreateAddPerson();
            //Contact contact2 = new Contact()
            //{
            //    id = 6,
            //    type = "2"
            //};
            //operation.AddPersonValues(contact2);
            List<Contact> list = new List<Contact>();
            list.Add(new Contact()
            {
                firstname = "Rithika",
                lastname = "Logachandran",
                address = "Madhavaram",
                city = "Chennai",
                state = "TamilNadu",
                zip = 600051,
                phonenumber = "9789286965",
                email = "rithi@gmail.com"
            });
            list.Add(new Contact()
            {
                firstname = "Yuvanthika",
                lastname = "S",
                address = "Vellore",
                city = "Chennai",
                state = "TamilNadu",
                zip = 600051,
                phonenumber = "467778999",
                email = "yuvanthi@gmail.com"
            });
            list.Add(new Contact()
            {
                firstname = "Soundarya",
                lastname = "S",
                address = "Korattur",
                city = "Chennai",
                state = "TamilNadu",
                zip = 600051,
                phonenumber = "8908765342",
                email = "Sound@gmail.com"
            });
            list.Add(new Contact()
            {
                firstname = "Riya",
                lastname = "Reji",
                address = "Kasimedu",
                city = "Chennai",
                state = "TamilNadu",
                zip = 600051,
                phonenumber = "7869087564",
                email = "riya@gmail.com"
            });
            list.Add(new Contact()
            {
                firstname = "lohini",
                lastname = "S",
                address = "OMR",
                city = "Chennai",
                state = "TamilNadu",
                zip = 600051,
                phonenumber = "6785643098",
                email = "lohini@gmail.com"
            });
            operation.UsingWithThread(list);
            operation.UsingWithoutThread(list);
        }
    }
}
