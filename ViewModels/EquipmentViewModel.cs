using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using mob_equipmentApp.Models;

namespace mob_equipmentApp.ViewModels
{
    public class EquipmentViewModel : ObservableObject
    {
        //EquipmentDatabase golfEquipmentDatabase = new EquipmentDatabase();

        int _id;
        String _name;
        String _imgPath;

        public int Id
        {
            get { return _id; }
            set => SetProperty(ref _id, value); // Antaa lisähyötyä, kun käytetään CommunityToolkit.Mvvm.ComponentModel pakettia
            // Jos muutoksia, tekee tapahtuman ja kuuluttaa siitä
            // automaattinen sidonta käyttöliittymän ja datan välillä
        }

        public String Name
        {
            get { return _name; }
            set => SetProperty(ref _name, value);
        }

        public String ImgPath
        {
            get { return _imgPath; }
            set => SetProperty(ref _imgPath, value);
        }

        // näytetään haluttu varuste
        public EquipmentViewModel(Equipment equipment)
        {
            _id = equipment.Id;
            _name = equipment.Name;
            _imgPath = equipment.ImgPath;
        }

    }
}
