using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorConnect.Models
{
    public class TutorProfileModel
    {
        public string TutorId { get; set; }
        public string FirstName { get; set; }
        public string  MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string AreaId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string HighestEducation { get; set; }
        public string AreaofExpertise { get; set; }
        public string AddInformation { get; set; }

    }
}