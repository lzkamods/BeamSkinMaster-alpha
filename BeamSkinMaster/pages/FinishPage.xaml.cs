using BeamSkinMaster.classes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FinishPage : Page
    {
        public FinishPage()
        {
            this.InitializeComponent();
            zipnametext.Text = ChoosingNamePage.inttxt + ".zip";
        }

        private void folderbutton_Click(object sender, RoutedEventArgs e)
        {
            string source = Path.Combine(pathes.dir, "vehicles");
            Process.Start("explorer.exe", source);
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void restartbtn_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }
    }
}
