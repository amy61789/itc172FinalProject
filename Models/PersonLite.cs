using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    public class PersonLite
    {
        public int PersonKey { set; get; }
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Email { set; get; }
        public string Apartment { set; get; }
        public string Street { set; get; }
        public string City { set; get; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Password { get; set; }
    }
}