using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiard_Loft_Membership_List
{
    class DatabaseLink
    {
        public List<string> getMemberFirstName()
        {
            List<string> allMembersFirstName = new List<string>();
            using(var db = new MembersListEntities())
            {
                allMembersFirstName = (from mems in db.members select mems.firstName).ToList();
                db.Dispose();
            }
            return allMembersFirstName;
        }

        public List<member> getFullMemberList()
        {
            //Master List - All Members
            List<member> members;
            //First Name
            List<string> firstName = new List<string>();
            //Last Name
            List<string> lastName = new List<string>();
            //Membership Start Date List
            List<string> start = new List<string>();
            //Membership End Date List
            List<string> end = new List<string>();
            //Membership Expired? 
            bool expired;
            // Member ID (Primary Key)
            List<long> id = new List<long>();

            using(var db = new MembersListEntities())
            {
                firstName = (from mems in db.members select mems.firstName).ToList();
                lastName = (from mems in db.members select mems.lastName).ToList();
                start = (from mems in db.members select mems.membershipStartDate).ToList();
                end = (from mems in db.members select mems.membershipEndDate).ToList();
                id = (from mems in db.members select mems.Id).ToList();
            }

            members = new List<member>(firstName.Count());
            for (int i = 0; i < firstName.Count(); i++)
            {
                expired = isMembershipExpired(end[i]);
                //Adds a new instance of the member class with the values pulled from the individual lists above. 
                //Full name derived on the spot from the concat. of first and last
                members.Add(new member { firstName = firstName[i], lastName = lastName[i], fullName = firstName[i] + " " + lastName[i], 
                    membershipStartDate = start[i], membershipEndDate = end[i], membershipExpired = expired, Id = id[i]});
            }

            return members;
        }

        public bool isMembershipExpired(string endDate)
        {
            DateTime end;

            end = DateTime.ParseExact(endDate, "MM/dd/yyyy", null);

            return _isMembershipExpired(end);
        }

        private bool _isMembershipExpired(DateTime endDate)
        {
            DateTime today = DateTime.Today;

            if(endDate <= today)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<member> getExpiredMembers(List<member> mems)
        {
            List<member> expired = new List<member>();

            //Loop through every member passed to this function and check if their expired bool is true
            foreach (member mem in mems)
            {
                if (mem.membershipExpired == true)
                {
                    //If so, add to a new list which will get returned
                    expired.Add(mem);
                }
            }

            return expired;
        }

        public void addToDatabase(string fname, string lname, string sDate, string eDate)
        {
            using(var db = new MembersListEntities())
            {
                member newMember = new member
                {
                    // ID of every new object is one more than the ID of the last object in the table
                    Id = generateID(),
                    firstName = fname,
                    lastName = lname,
                    membershipStartDate = sDate,
                    membershipEndDate = eDate
                };

                db.members.Add(newMember);
                db.SaveChanges();
                db.Dispose(); // I believe the "using" statement renders this redundant but hey, YouTube said so
            }
        }

        private long generateID() 
        {
            // Count+1 only works as long as members aren't deleted from the list, which they are in this application
            // This method will ensure that the new ID is always one greater than the highest ID currently in the database, whatever that may be

            List<member> allMembers = new List<member>();
            List<long> allIDs = new List<long>();
            long newid;

            allMembers = getFullMemberList();

            foreach (member mem in allMembers)
            {
                allIDs.Add(mem.Id);
            }
            if (allIDs.Count > 0)
            {
                newid = allIDs.Max() + 1;
            }
            else
            {
                // If the database is empty, the ID will start at 1
                newid = 1;
            }


            return newid;
        }

        public void renewMembership(member memForRenew, DateTime tday)
        {
            // http://www.dotnetcurry.com/entityframework/619/add-update-delete-objects-entity-framework

            long id = memForRenew.Id;

            using (var db = new MembersListEntities())
            {
                DateTime newExpire;
                bool exp;

                // If the membership is expired, we add one month to today
                // If the membership is not expired, add one month to their current exp. date
                member m = db.members.First(i => i.Id == id);
                newExpire = DateTime.ParseExact(m.membershipEndDate, "MM/dd/yyyy", null);
                exp = _isMembershipExpired(newExpire);

                if (exp == true)
                {
                    newExpire = tday.AddMonths(1);
                }
                else
                {
                    newExpire = newExpire.AddMonths(1);
                }
                m.membershipEndDate = newExpire.ToString("MM/dd/yyyy");
                db.SaveChanges();
                
            }
        }

        public void deleteMember(long id)
        {
            // https://visualstudiomagazine.com/blogs/tool-tracker/2015/12/entity-framework-database-deletes.aspx
            using (var db = new MembersListEntities())
            {
                member m = db.members.First(i => i.Id == id);
                db.members.Attach(m);
                db.members.Remove(m);
                db.SaveChanges();
                
            }
            
        }
    }
}
