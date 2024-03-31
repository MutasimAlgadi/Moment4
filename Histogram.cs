using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment4
{
    internal class Histogram
    {
        public void AddText()
        {
            string text = "We recommend reading this tutorial, in the sequence listed in the menu.";
            text = text.Replace(".", ""); // ta bort alla punktar
            text = text.Replace(",", ""); // ta bort alla komma

            string[] array = text.Split();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            List<string> mytext = new List<string>();
            mytext.AddRange(array);

            foreach(var item in mytext)
            {
                var output = mytext.FindAll(a=> a.Contains(item));
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, output.Count);
                }
            }

            var mylist = dictionary.ToList();
            // sortera från lägsta till största
            mylist.Sort((pair1,pair2) =>pair1.Value.CompareTo(pair2.Value));
            // sortera från största til lägsta  
            mylist.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            foreach (var item in mylist)
            {
                Console.WriteLine(item.Key+ ": "+ item.Value);
            }

        }
    }
}
