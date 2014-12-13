using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WpfMasterChild.ViewModels
{
    public class ThneedCollection
    {
        public ThneedCollection()
        {
            this.AllThneeds = new ObservableCollection<Thneed>()
            {
                new Thneed { Name = "Red Thneed", ThneedColor = Colors.Red },
                new Thneed { Name = "Green Thneed", ThneedColor = Colors.Green },
                new Thneed { Name = "Blue Thneed", ThneedColor = Colors.Blue }
            };
        }

        public ObservableCollection<Thneed> AllThneeds
        {
            get;
            set;
        }
    }
}
