using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    // Methods for working with the Slip table
    public static class SlipManager
    {
        /// <summary>
        /// Gets all slips
        /// </summary>
        /// <returns>List of all sips</returns>
        public static List<Slip> GetAllSlips()
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Slips.Include(d => d.Dock).ToList();
        }

        /// <summary>
        /// Gets the slip with provided ID
        /// </summary>
        /// <param name="slipID">ID to find slip</param>
        /// <returns>Slip for provided ID</returns>
        public static Slip GetSlipWithID(int slipID)
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Slips.Find(slipID);
        }

        /// <summary>
        /// Gets all unleased slips
        /// </summary>
        /// <returns>List of all slips that are not leased</returns>
        public static List<Slip> GetAllUnleasedSlips()
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Slips.Include(d => d.Dock).Where(s => s.Leases.Count == 0).ToList();
        }

        /// <summary>
        /// Gets unleased slips by dock ID
        /// </summary>
        /// <param name="selectedDockID"> DockID for finding slips </param>
        /// <returns> List of all slips for respective dock id </returns>
        public static List<Slip> GetUnleasedSlipsByDock(int selectedDockID)
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Slips.Include(d => d.Dock).Where(s => s.Leases.Count == 0 && s.DockID == selectedDockID).ToList();
        }

       
    }
}
