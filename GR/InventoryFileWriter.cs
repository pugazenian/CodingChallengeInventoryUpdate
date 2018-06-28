using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR
{
    public class InventoryFileWriter
    {
        public IList<Item> Items;
        public InventoryFileWriter(IList<Item> items)
        {
            Items = items;
        }

        public void Write()
        {
            var filename = string.Format("inventory_{0}.txt", DateTime.Now.ToString("yyyyddMM-HHmmss"));

            try
            {
                var inventoryOutput = JsonConvert.SerializeObject(this.Items, Formatting.Indented);
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename), inventoryOutput);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error while writing updated inventory details to a file" + ex.Message);
            }
        }
    }
}
