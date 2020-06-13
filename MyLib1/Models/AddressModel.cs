using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib1.Models
{
    public class AddressModel
    {
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress
        {
            get 
            { 
                return $"{StreetAddress}, {City}, {State}, {ZipCode}"; 
            }
        }

    }
}
