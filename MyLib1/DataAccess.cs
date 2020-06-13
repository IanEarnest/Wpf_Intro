using MyLib1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib1
{
    public class DataAccess
    {
        Random rnd = new Random();
        string[] streetAddresses = new string[] { "Address1", "Address2", "Address3" };
        string[] cities = new string[] { "City1", "City2", "City3" };
        string[] states = new string[] { "State1", "State2", "State3" };
        string[] zipCodes = new string[] { "ZIP1", "ZIP2", "ZIP3" };
        string[] firstNames = new string[] { "Steve1", "Steve2", "Steve3" };
        string[] lastNames = new string[] { "Smith1", "Smith2", "Smith3" };
        bool[] aliveStatuses = new bool[] {true, false};
        DateTime lowEndDate = new DateTime(1943, 1, 1);
        int daysFromLowDate;
        
        public DataAccess()
        {
            daysFromLowDate = (DateTime.Today - lowEndDate).Days;
        }

        public List<PersonModel> GetPeople(int total = 10)
        {
            List<PersonModel> output = new List<PersonModel>();
            for (int i = 0; i < total; i++)
            {
                output.Add(GetPerson(i + 1));
            }
            return output;
        }
        public PersonModel GetPerson(int id)
        {
            PersonModel output = new PersonModel();

            output.PersonId = id;
            output.FirstName = GetRandomItem(firstNames);
            output.LastName = GetRandomItem(lastNames);
            output.IsAlive = GetRandomItem(aliveStatuses);
            output.DateOfBirth = GetRandomDate();
            output.Age = GetAgeInYears(output.DateOfBirth);
            output.AccountBalance = ((decimal)rnd.Next(1, 1000000) / 100);

            int addressCount = rnd.Next(1, 5);

            for (int i = 0; i < addressCount; i++)
            {
                output.Addresses.Add(GetAddress(((id - 1) * 5) + i + 1));
            }

            return output;
        }
        private AddressModel GetAddress(int id)
        {
            AddressModel output = new AddressModel();

            output.AddressID = id;
            output.StreetAddress = GetRandomItem(streetAddresses);
            output.City = GetRandomItem(cities);
            output.State = GetRandomItem(states);
            output.ZipCode = GetRandomItem(zipCodes);

            return output;
        }
        public T GetRandomItem<T>(T[] data)
        {
            return data[rnd.Next(0, data.Length)];
        }
        public DateTime GetRandomDate()
        {
            return lowEndDate.AddDays(rnd.Next(daysFromLowDate));
        }
        public int GetAgeInYears(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if(now < birthday.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
