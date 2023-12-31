﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSqlQuery
{
    public class Operation
    {
        private SqlConnection con;
        private void Connection()
        {
            string connectionStr = "data source = (localdb)\\MSSQLLocalDB; initial catalog = Addressbook_service; integrated security = true";
            con = new SqlConnection(connectionStr);
        }
        public void AddContactDetails(Contact obj)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("AddContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstname", obj.firstname);
                com.Parameters.AddWithValue("@lastname", obj.lastname);
                com.Parameters.AddWithValue("@address", obj.address);
                com.Parameters.AddWithValue("@city", obj.city);
                com.Parameters.AddWithValue("@state", obj.state);
                com.Parameters.AddWithValue("@zip", obj.zip);
                com.Parameters.AddWithValue("@phonenumber", obj.phonenumber);
                com.Parameters.AddWithValue("@email", obj.email);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Added");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void EditContactDetails(Contact obj)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("EditContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstname", obj.firstname);
                com.Parameters.AddWithValue("@lastname", obj.lastname);
                com.Parameters.AddWithValue("@address", obj.address);
                com.Parameters.AddWithValue("@city", obj.city);
                com.Parameters.AddWithValue("@state", obj.state);
                com.Parameters.AddWithValue("@zip", obj.zip);
                com.Parameters.AddWithValue("@phonenumber", obj.phonenumber);
                com.Parameters.AddWithValue("@email", obj.email);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Updated");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteContactDetails(string firstname)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("DeleteContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstname", firstname);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Deleted");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void DetailsinCity(string city)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("DetailsinCity", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@city", city);
                con.Open();
                int i = com.ExecuteNonQuery();
                List<Contact> addressBook = new List<Contact>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new Contact
                        {
                            id = Convert.ToInt32(dr["id"]),
                            firstname = Convert.ToString(dr["firstname"]),
                            lastname = Convert.ToString(dr["lastname"]),
                            address = Convert.ToString(dr["address"]),
                            city = Convert.ToString(dr["city"]),
                            state = Convert.ToString(dr["state"]),
                            zip = Convert.ToInt32(dr["zip"]),
                            phonenumber = Convert.ToString(dr["phonenumber"]),
                            email = Convert.ToString(dr["email"]),
                        });
                }
                Console.WriteLine("persons in city " + city + " are: ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.firstname + " " + data.lastname);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void DetailsinState(string state)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("DetailsinState", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@state", state);
                con.Open();
                int i = com.ExecuteNonQuery();
                List<Contact> addressBook = new List<Contact>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new Contact
                        {
                            id = Convert.ToInt32(dr["id"]),
                            firstname = Convert.ToString(dr["firstname"]),
                            lastname = Convert.ToString(dr["lastname"]),
                            address = Convert.ToString(dr["address"]),
                            city = Convert.ToString(dr["city"]),
                            state = Convert.ToString(dr["state"]),
                            zip = Convert.ToInt32(dr["zip"]),
                            phonenumber = Convert.ToString(dr["phonenumber"]),
                            email = Convert.ToString(dr["email"]),
                        });
                }
                Console.WriteLine("Persons in the state " + state + " are: ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.firstname + " " + data.lastname);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void CountInCity()
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("CountinCity", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                int i = com.ExecuteNonQuery();
                List<Contact> addressBook = new List<Contact>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new Contact
                        {
                            city = Convert.ToString(dr["city"]),
                            count = Convert.ToInt32(dr["count"])
                        });
                }
                Console.WriteLine("No.of persons in each city are ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.city + "--" + data.count);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void CountInState()
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("CountinState", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                int i = com.ExecuteNonQuery();
                List<Contact> addressBook = new List<Contact>();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new Contact
                        {
                            state = Convert.ToString(dr["state"]),
                            count = Convert.ToInt32(dr["count"])
                        });
                }
                Console.WriteLine("No.of persons in each state are ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.state + "--" + data.count);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void CountByType()
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("CountByType", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                List<Contact> addressBook = new List<Contact>();
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    addressBook.Add(
                        new Contact
                        {
                            type = Convert.ToString(dr["type"]),
                            count = Convert.ToInt32(dr["count"])
                        });
                }
                Console.WriteLine("No.of persons in each type are: ");
                foreach (var data in addressBook)
                {
                    Console.WriteLine(data.type + "--" + data.count);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void CreateAddPerson()
        {
            try
            {
                Connection();
                string query = "Create table AddPerson(id int primary key identity(1,1), " + "contactId int Foreign Key References AddressBook(id)," + "type int Foreign Key References type(id));";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Created table Suceesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No table Created "+ex);
            }
            finally 
            {
                con.Close();
            }

        }

        public void AddPersonValues(Contact obj)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("AddPersonValues", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@contactId", obj.id);
                com.Parameters.AddWithValue("@type", obj.type);
                con.Open();
                com.ExecuteNonQuery();
                Console.WriteLine("Contact Added");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void UsingWithThread(List<Contact> list)
        {
            DateTime start = DateTime.Now;
            foreach(var data in list)
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Being Added:" + data.firstname);
                    AddContactDetails(data);
                    Console.WriteLine("Added:" + data.firstname);
                });
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duration with Thread: "+ (end- start));
        }

        public void UsingWithoutThread(List<Contact> list)
        {
            DateTime start = DateTime.Now;
            foreach(var data in list)
            {
                AddContactDetails(data);
                
            }
            DateTime end = DateTime.Now;
            Console.WriteLine("Duartion without thread: " + (end - start));
        }


    }
}
