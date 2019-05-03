using System;
using System.Collections.Generic;

namespace  DevExpress.DemoData.Models
{
    public partial class Employee
    {
        public long EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<long> ReportsTo { get; set; }
        public string Email { get; set; }

        public string PageHeader { get { return (FirstName + " " + LastName).ToUpper(); } }
        public string PageContent {
            get {
                return FirstName + " " + LastName + " was born on " + DateToString(BirthDate) + ". Now lives at " +
                    City + ", " + Country + ". " + TitleOfCourtesy + " " + LastName + " holds a position of " + Title + " our " +
                    Region + " deparment, (" + City + " " + Country + "). Joined our company on " + DateToString(HireDate) + ".";
            }
        }
        string DateToString(DateTime? date) {
            if(date == null)
                return null;
            string[] Months = { "January", "February", "Marth", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return date.Value.Day + "th of " + Months[date.Value.Month - 1] + " in " + date.Value.Year;
        }

    }
}
