using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mob_equipmentApp.Models
{
    internal class EquipmentDatabase
    {
        public async static Task<IEnumerable<Equipment>> GetEquipment()
        {
            using Stream stream = await FileSystem.OpenAppPackageFileAsync("data.json");


            System.Text.Json.JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
            };

            IEnumerable<Equipment>? equipment = await System.Text.Json.JsonSerializer.DeserializeAsync<List<Equipment>>(stream, options);

            return equipment ?? [];
        }
    }
}
