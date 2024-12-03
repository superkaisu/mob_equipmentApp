using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_equipmentApp.Models
{
    internal class EquipmentDatabase
    {
        Equipment[] ironClubs = new Equipment[4];

        public EquipmentDatabase() 
        {
            ironClubs[0] = new Equipment(1, "6 Iron");
            ironClubs[1] = new Equipment(2, "7 Iron");
            ironClubs[2] = new Equipment(3, "8 Iron");
            ironClubs[3] = new Equipment(4, "9 Iron");
        }

        public Equipment[] GetEquipment() 
        { 
            return ironClubs;
        }
    }
}
