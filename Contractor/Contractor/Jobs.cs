using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contractor
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
        public string Cost { get; set; }
        public string CompleteDescription { get; set; }
        public Boolean Finished { get; set; }

        public void AddJob(int clientID, int contractorID, String description, String location, DateTime dateTime, bool priority)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get job collection
                var jobs = db.GetCollection<Job>("jobs");

                // Create your new customer instance
                var job = new Job
                {
                    ClientID = clientID,
                    ContractorID = contractorID,
                    Description = description,
                    Location = location,
                    DateTime = dateTime,
                    Priority = priority,
                    Cost = "",
                    CompleteDescription = "",
                    Finished = false
                };

                // Insert new customer document (Id will be auto-incremented)
                jobs.Insert(job);
            }
        }

        //Updates the job with new information
        public void UpdateJob(int JobID, string CompleteCost, string CompleteDescription, Boolean FinishedCheck)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                var jobs = db.GetCollection<Job>("jobs");

                Job job = GetJob(JobID);

                job.Cost = CompleteCost;
                job.CompleteDescription = CompleteDescription;
                job.Finished = FinishedCheck;

                jobs.Update(job);
            }
        }

        public Job GetJob(int clientID, int contractorID)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get job collection
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

        public Job GetJob(int jobID)
        {
            // Open database (or create if not exits)
            using (var db = new LiteDatabase(@"IQIncorporated.db"))
            {
                // Get job collection
                var jobs = db.GetCollection<Job>("jobs");

                // Use Linq to query documents
                var results = jobs.Find(x => x.ID.Equals(jobID));

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

        //returns all jobs for a contractor
        public Job[] JobList(string contractorID) {
            int CleanID;

            if (Int32.TryParse(contractorID, out CleanID))
            {
                // Open database (or create if not exits)
                using (var db = new LiteDatabase(@"IQIncorporated.db"))
                {
                    // Get clients collection
                    var jobs = db.GetCollection<Job>("jobs");

                    Job[] jobList = jobs.Find(Query.EQ("ContractorID", CleanID)).ToArray();

                    System.Diagnostics.Debug.WriteLine(CleanID);
                    System.Diagnostics.Debug.WriteLine(jobList.Length);

                    return jobList;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
