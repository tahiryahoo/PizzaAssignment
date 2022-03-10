using InventoryService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryService.Infrastructure.Library
{
    public class ProductDBContext
    {
        private static ProductDBContextModel _ProductDBContextModel { get; set; }
       
        public static ProductDBContextModel ReadJsonDB() {

            if (_ProductDBContextModel == null)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "App_Data\\ProductDatabase.json");
                var serializerOptions = new JsonSerializerOptions
                {
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    AllowTrailingCommas = true
                };

                var jsonContent = File.ReadAllText(filePath);
                _ProductDBContextModel = JsonSerializer.Deserialize<ProductDBContextModel>(jsonContent, serializerOptions);
            }
            return _ProductDBContextModel;
        }
    }
}
