using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBase
{
    class Contractor
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LandLine { get; set; }
        public string Mobile { get; set; }
        public string EmployeeID { get; set; }
        public string Email { get; set; }

        public void AddContractor(String name, String address, String landLine, String mobile, String employeeID, String email)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get contractors collection
                var contractors = db.GetCollection<Contractor>("contractors");

                // Create your new contractor instance
                var contractor = new Contractor
                {
                    Name = name,
                    Address = address,
                    LandLine = landLine,
                    Mobile = mobile,
                    EmployeeID = employeeID,
                    Email = email
                };

                // Insert new customer document (Id will be auto-incremented)
                contractors.Insert(contractor);
            }
        }

        public Contractor GetContractor(String email)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get clients collection
                var contractors = db.GetCollection<Contractor>("contractors");

                // Use Linq to query documents
                var results = contractors.Find(x => x.Email.Equals(email));

                if (results.Count() > 0)
                {
                    return results.First();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
