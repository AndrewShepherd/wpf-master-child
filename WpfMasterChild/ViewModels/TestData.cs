using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfMasterChild.ViewModels
{
    public static class TestData
    {
        public static Thneed TestThneed
        {
            get
            {
                return new Thneed
                {
                    Name = "Test Thneed",
                    ThneedColor = Colors.Purple
                };
            }
        }

    }
}
