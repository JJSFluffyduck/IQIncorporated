using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBase
{
    class Job
    {

        public int ID { get; set; }
        public int ClientID { get; set; }
        public int ContractorID { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
        public bool Priority { get; set; }

        public void AddJob(int clientID, int contractorID, String description, String location, DateTime dateTime, bool priority)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get client collection
                var jobs = db.GetCollection<Job>("jobs");

                // Create your new customer instance
                var job = new Job
                {
                    ClientID = clientID,
                    ContractorID = contractorID,
                    Description = description,
                    Location = location,
                    DateTime = dateTime,
                    Priority = priority
                };

                // Insert new customer document (Id will be auto-incremented)
                jobs.Insert(job);
            }
        }

        public Job GetJob(int clientID, int contractorID)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get clients collection
                var jobs = db.GetCollection<Job>("jobs");

                // Use Linq to query documents
                var results = jobs.Find(x => x.ClientID.Equals(clientID) && x.ContractorID.Equals(contractorID));

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
