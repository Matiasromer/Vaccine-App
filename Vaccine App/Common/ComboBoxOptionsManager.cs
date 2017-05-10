using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Common
{
    public class ComboBoxOptionsManager
    {
        public static void GetComboBoxList(ObservableCollection<ComboBoxItem> ComboBoxItems)
        {
            var allItems = getComboBoxItems();
            ComboBoxItems.Clear();
            allItems.ForEach(p => ComboBoxItems.Add(p));
        }

        private static List<ComboBoxItem> getComboBoxItems()
        {
            var items = new List<ComboBoxItem>();

            items.Add(new ComboBoxItem() { ComboBoxOption = "Pige", ComboBoxHumanReadableOption = "Pige" });
            items.Add(new ComboBoxItem() { ComboBoxOption = "Dreng", ComboBoxHumanReadableOption = "Dreng" });

            return items;
        }
    }

}
