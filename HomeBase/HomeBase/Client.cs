using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBase
{
    class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LandLine { get; set; }
        public string Mobile { get; set; }
        public string Business { get; set; }
        public string Email { get; set; }

        public void AddClient(String name, String address, String landLine, String mobile, String business, String email)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get client collection
                var clients = db.GetCollection<Client>("clients");

                // Create your new customer instance
                var client = new Client
                {
                    Name = name,
                    Address = address,
                    LandLine = landLine,
                    Mobile = mobile,
                    Business = business,
                    Email = email
                };

                // Insert new customer document (Id will be auto-incremented)
                clients.Insert(client);
            }
        }

        public Client GetClient(String email)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get clients collection
                var clients = db.GetCollection<Client>("clients");

                // Use Linq to query documents
                var results = clients.Find(x => x.Email.Equals(email));

                return results.First();
            }
        }
    }


}
