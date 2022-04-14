using InlandMarinaData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlandMarinaMVC.ViewComponents
{
    public class SlipsByDock: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {

            List<Slip> slips;

            if (id == 0) // Default "All" selection
            {
                // Get all unleased slips
                slips = SlipManager.GetAllUnleasedSlips();
            }
            else
            {
                // Get unleased slips by the dock id
                slips = SlipManager.GetUnleasedSlipsByDock(id);
            }

            return View(slips);
        }
    }
    
}