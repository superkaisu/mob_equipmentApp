using mob_equipmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace mob_equipmentApp.ViewModels
{
    public class EquipmentListViewModel : ObservableObject
    {
        EquipmentDatabase equipmentDatabase = new EquipmentDatabase();

        // tämä sitä varten, kun käyttäjä valitsee varusteen - voidaan näyttää tietoja
        private EquipmentViewModel _selectedEquipment;

        public EquipmentViewModel SelectedEquipment
        {
            get => _selectedEquipment;
            set => SetProperty(ref _selectedEquipment, value);
        }

        public ObservableCollection<EquipmentViewModel> Equipment { get; set; }

        public EquipmentListViewModel() => Equipment = [];

        public async Task RefreshEquipment()
        {
            Equipment[] equipmentData = equipmentDatabase.GetEquipment();

            foreach (Models.Equipment equipment in equipmentData)
                Equipment.Add(new EquipmentViewModel(equipment));

        }

        public void DeleteEquipment(EquipmentViewModel equipment) => Equipment.Remove(equipment);

    }
}
