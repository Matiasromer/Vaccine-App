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
        public static void GetComboBoxList(ObservableCollection<Windows.UI.Xaml.Controls.ComboBoxItem> ComboBoxItems)
        {
            var allItems = getComboBoxItems();
            ComboBoxItems.Clear();
            allItems.ForEach(p => ComboBoxItems.Add(p));
        }

        private static List<Windows.UI.Xaml.Controls.ComboBoxItem> getComboBoxItems()
        {
            var items = new List<Windows.UI.Xaml.Controls.ComboBoxItem>();
            Windows.UI.Xaml.Controls.ComboBoxItem item1 = new Windows.UI.Xaml.Controls.ComboBoxItem();
            Windows.UI.Xaml.Controls.ComboBoxItem item2 = new Windows.UI.Xaml.Controls.ComboBoxItem();

            item1.Content = "Pige";
            item2.Content = "Dreng";

            //items.Add(new Windows.UI.Xaml.Controls.ComboBoxItem() { ComboBoxOption = "Pige", ComboBoxHumanReadableOption = "Pige" });
            items.Add(item1);
            items.Add(item2);


            return items;
        }
    }

}
