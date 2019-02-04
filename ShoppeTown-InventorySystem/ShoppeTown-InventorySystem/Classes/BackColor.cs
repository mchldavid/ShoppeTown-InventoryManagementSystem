using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppeTown_InventorySystem.Classes
{
    class BackColor
    {
        public void getBackColor(string click)
        {
            if (click == "1")
            {
                btnDashboard.Normalcolor = Color.FromArgb(182, 89, 5);
                btnPurchaseRequest.Normalcolor = Color.FromArgb(21, 32, 40);
                btnPurchaseOrder.Normalcolor = Color.FromArgb(21, 32, 40);
                btnFASM.Normalcolor = Color.FromArgb(21, 32, 40);
                btnRegistration.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogs.Normalcolor = Color.FromArgb(21, 32, 40);
                btnLogout.Normalcolor = Color.FromArgb(21, 32, 40);
            }
        }
    }
}
