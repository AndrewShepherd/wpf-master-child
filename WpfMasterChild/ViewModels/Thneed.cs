using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Windows.Media.Color;

namespace WpfMasterChild.ViewModels
{
    public class Thneed : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    var dg = this.PropertyChanged;
                    if (dg != null)
                    {
                        dg(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
        }

        private Color _color;
        public Color ThneedColor
        {
            get
            {
                return _color;
            }
            set
            {
                if (_color != value)
                {
                    _color = value;
                    var dg = this.PropertyChanged;
                    if (dg != null)
                    {
                        dg(this, new PropertyChangedEventArgs("ThneedColor"));
                    }
                }
                }
            }
        }


    }

