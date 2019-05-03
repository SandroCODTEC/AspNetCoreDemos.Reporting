﻿using System;

namespace AspNetCoreDemos.Reporting.Reports.CachedDocumentSource {
    public class DataItem {
        static string[] accountType = new string[] { "Energy", "Manufacturing", "Estate", "Food", "Services" };
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Invoice { get; set; }
        public string CustomerAccount { get; set; }
        public string CustomerIdentifiers { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime BillingPeriodStart { get; set; }
        public DateTime BillingPeriodEnd { get; set; }
        public string Terms { get; set; }
        public string TermsID { get; set; }
        public Adjustment[] Adjustments { get; set; }


        public DataItem(int i) {
            var rnd = new DeterministicRandom(i);
            Customer c = rnd.GetRandomItem(Customer.Customers);
            CustomerID = c.CustomerID;
            CompanyName = c.CompanyName;
            ContactName = c.ContactName;
            ContactTitle = c.ContactTitle;
            Address = c.Address;
            City = c.City;
            PostalCode = c.PostalCode;
            Region = c.Region;
            Country = c.Country;
            Phone = c.Phone;
            Fax = c.Fax;
            Email = ContactName.Split(' ')[0].Replace(' ', '.').ToLower() + "@" + CompanyName.Split(' ')[0].ToLower() + ".com";
            Invoice = string.Format("{0}{1}-{2}", rnd.RandomLitera, rnd.Random(100, 1000), rnd.Random(100, 1000));
            CustomerAccount = rnd.GetRandomItem(accountType);
            CustomerIdentifiers = string.Format("{0}-{1}", rnd.Random(1000, 10000), rnd.Random(10, 100));
            BillingPeriodStart = rnd.RandomTime();
            BillingPeriodEnd = rnd.RandomTime(BillingPeriodStart, 7 * 24, 30 * 24);
            BillingDate = rnd.RandomTime(BillingPeriodEnd, 7 * 24, 30 * 24);
            Term term = rnd.GetRandomItem(Term.Terms);
            Terms = term.Name;

            int adjustmentsCount = rnd.Random(6) + 4;
            Adjustments = new Adjustment[adjustmentsCount];
            int h = (int)((BillingPeriodEnd - BillingPeriodStart).TotalHours / adjustmentsCount);

            var adj = Adjustments[0] = Adjustment.CreateBalanceForward(rnd.RandomTime(BillingPeriodStart, 0, h), rnd.Random(10000));

            int[] items = rnd.RandomList(adjustmentsCount - 1, 2);

            for(int j = 1; j < Adjustments.Length; j++) {
                DateTime nextDate = rnd.RandomTime(BillingPeriodStart.AddHours(h * j), 0, h);
                    switch(items[j - 1]) {
                        case 0:
                            adj = Adjustments[j] = Adjustment.CreateCharge(nextDate, rnd.Random(10000));
                            break;
                        case 1:
                            adj = Adjustments[j] = Adjustment.CreatePayment(nextDate, rnd.Random(10000));
                            break;
                    }
            }
        }
    }
}
