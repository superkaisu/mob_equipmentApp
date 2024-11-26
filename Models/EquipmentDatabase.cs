using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_equipmentApp.Models
{
    internal class EquipmentDatabase
    {
        Equipment ironClub_6 = new Equipment(1, "6 Iron");

        public Equipment GetEquipment() 
        { 
            return ironClub_6;
        }
    }
}
