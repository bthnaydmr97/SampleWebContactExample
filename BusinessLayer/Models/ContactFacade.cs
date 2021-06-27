using Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class ContactFacade
    {
        //For Db Connection
       public KeyValuePair<bool,string> SendMessage(ContactDto contact)
        {
            var result = new KeyValuePair<bool, string>(true, "Başarılı");
            try
            {

                contact.Date = DateTime.Today;

                var send = new Contact
                {
                    Name = contact.Name,
                    Surname = contact.Surname,
                    Age = contact.Age,
                    City = contact.City,
                    CreatedDate = DateTime.Today
                };
            }
            catch (Exception ex)
            {
                result = new KeyValuePair<bool, string>(false, ex.Message);
            }

            return result;
        }

        public List<string> GetAllCities()
        {
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            cities.Add("Çanakkale");
            cities.Add("Bursa");

            return cities;
        }
    }
}
