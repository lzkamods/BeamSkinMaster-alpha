using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using WinRT.Interop;
using System.Drawing;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private AppWindow m_AppWindow;

        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);

            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = 430, Height = 569 });

            string dir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
            string pth = System.IO.Path.Combine(dir, "vehicles");
            Directory.CreateDirectory(pth);

        }

        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WindowNative.GetWindowHandle(this);
            WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(wndId);
        }

        private string combobox;

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Combobox1.SelectedIndex;
            string text = Combobox1.Items[index].ToString();
            kakaka.Text = text;
            string direrctory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
            string dirrr = System.IO.Path.Combine(direrctory + @"\vehicles");

            string auto = e.AddedItems[0].ToString();
            switch (auto)
            {
                case "Autobello Piccolina":
                    text = "autobello";
                    break;

                case "Autobello Stambecco":
                    text = "midtruck";
                    break;

                case "Bruckell Bastion":
                    text = "bastion";
                    break;

                case "Bruckell LeGran":
                    text = "legran";
                    break;

                case "Burnside Special":
                    text = "burnside";
                    break;

                case "Cherrier Tograc":
                    text = "vivace";
                    break;
            }

            string path = System.IO.Path.Combine(dirrr, text);
            string Picco = path;
            vibiriauto.Text = Picco;

            string endpath = System.IO.Path.Combine(path, text);

            combobox = endpath;
        }

        public void page1dalee_Click(object sender, RoutedEventArgs e)
        {
            Directory.CreateDirectory(combobox);
            ContentFrame.Navigate(typeof(Page2), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            ProgressOnTop.Value = 37;
        }

        private void ProgressBarOn_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

    }
}
