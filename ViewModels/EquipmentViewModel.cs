using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using mob_equipmentApp.Models;

namespace mob_equipmentApp.ViewModels
{
    internal class EquipmentViewModel : ObservableObject
    {
        EquipmentDatabase golfEquipmentDatabase = new EquipmentDatabase();

        int _id;
        String _name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public EquipmentViewModel()
        {
            Equipment tmpEquipment = golfEquipmentDatabase.GetEquipment();
            _id = tmpEquipment.Id;
            _name = tmpEquipment.Name;
        }

    }
}
