using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public class LeaseManager
    {
        /// <summary>
        /// Gets all leases for the customer input
        /// </summary>
        /// <param name="custID">CustomerID for their respective lease</param>
        /// <returns>Lease for customer with custID</returns>
        public static List<Lease> GetLeasesForCustomer(int custID)
        {
            InlandMarinaContext db = new InlandMarinaContext();
            //var query = (from lease in db.Leases
            //            where lease.CustomerID == custID
            //            select lease).ToList();
            return db.Leases.Include(s => s.Slip).Where(l => l.CustomerID == custID).ToList();
        }

        /// <summary>
        /// Adds lease to database
        /// </summary>
        /// <param name="lease">Lease to add</param>
        public static void AddLease(Lease lease)
        {
            InlandMarinaContext db = new InlandMarinaContext();
            db.Leases.Add(lease);
            db.SaveChanges();
        }
    }
}
