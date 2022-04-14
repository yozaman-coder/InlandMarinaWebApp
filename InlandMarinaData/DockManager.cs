using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public class DockManager
    {
        /// <summary>
        /// Finds dock with given ID
        /// </summary>
        /// <param name="DockID">Dock ID for finding Dock</param>
        /// <returns>Dock for given ID</returns>
        public static Dock FindDockWithID(int DockID)
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Docks.Find(DockID);
        }

        /// <summary>
        /// Finds all docks
        /// </summary>
        /// <returns>List of all docks</returns>
        public static List<Dock> FindAllDocks()
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Docks.OrderBy(d => d.Name).ToList();
        }

        /// <summary>
        /// Gets all dock names as key value pairs
        /// </summary>
        /// <returns>All dock names as key value pairs</returns>
        public static IList GetAllDockNamesAsKeyValuePairs()
        {
            InlandMarinaContext db = new InlandMarinaContext();
            return db.Docks.OrderBy(d => d.Name).Select(d => new { Value = d.ID, Text = d.Name }).ToList();
        }
    }

}
