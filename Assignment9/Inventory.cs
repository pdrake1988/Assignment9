using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Inventory
    {
        public List<Tuple<string, int, float>> Items = new List<Tuple<string, int, float>>();

        public void AddItem(Tuple<string, int, float> item)
        {
            Items.Add(item);
        }

        public void UpdateQuantity(int quantity, string name)
        {
            int index = this.Items.Where(i => i.Item1 == name).Single().Item2;
            Items.ElementAt(index).Item2 = quantity;
        }
    }
}
