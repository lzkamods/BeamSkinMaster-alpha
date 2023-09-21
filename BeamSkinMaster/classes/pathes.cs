using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamSkinMaster.classes
{
    public class pathes
    {
        public static string dir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
        public static string pth = Path.Combine(dir, "vehicles");

        public static string direrctory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
        public static string dirrr = Path.Combine(direrctory + @"\vehicles");

        public static string endtxt = MainWindow.endtext;
    }
}
