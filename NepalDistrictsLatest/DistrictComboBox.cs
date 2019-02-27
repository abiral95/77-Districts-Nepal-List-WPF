using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Controls;

namespace NepalDistrictsLatest
{
    public class DistrictComboBox : ComboBox
    {
        public DistrictComboBox()
        {
            try
            {
                var districtsJson = File.ReadAllText("districts.json");
                var districts = JsonConvert.DeserializeObject<ObservableCollection<DistrictModel>>(districtsJson);
                ItemsSource = districts;
                DisplayMemberPath = "Name";
                SelectedValuePath = "Code";
            }
            catch(Exception e)
            {
            }

        }
    }
}
