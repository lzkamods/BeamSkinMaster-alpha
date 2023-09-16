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
using Microsoft.UI.Xaml.Documents;
using Windows.UI.Popups;

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
        public XamlRoot XamlRoot { get; set; }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Combobox1.SelectedIndex;
            string text = Combobox1.Items[index].ToString();
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

                case "Cherrier Vivace":
                    text = "vivace";
                    break;

                case "Civetta Bolide":
                    text = "bolide";
                    break;

                case "Civetta Scintilla":
                    text = "scintilla";
                    break;

                case "ETK 800 Series":
                    text = "etk800";
                    break;

                case "ETK I-Series":
                    text = "etki";
                    break;

                case "ETK K-Series":
                    text = "etkc";
                    break;

                case "Gavril Barstow":
                    text = "barstow";
                    break;

                case "Gavril Bluebuck":
                    text = "bluebuck";
                    break;

                case "Gavril D-Series":
                    text = "pickup";
                    break;

                case "Gavril Grand Marshal":
                    text = "fullsize";
                    break;

                case "Gavril H-Series":
                    text = "van";
                    break;

                case "Gavril Roamer":
                    text = "roamer";
                    break;

                case "Gavril T-Series":
                    text = "semi";
                    break;

                case "Hirochi SBR4":
                    text = "sbr";
                    break;

                case "Hirochi Sunburst":
                    text = "sunburst";
                    break;

                case "Ibishu 200BX":
                    text = "coupe";
                    break;

                case "Ibishu Covet":
                    text = "covet";
                    break;

                case "Ibishu Hopper":
                    text = "hopper";
                    break;

                case "Ibishu Miramar":
                    text = "miramar";
                    break;

                case "Ibishu Pessima 88":
                    text = "pessima";
                    break;

                case "Ibishu Pessima 96":
                    text = "midsize";
                    break;

                case "Ibishu Pigeon":
                    text = "pigeon";
                    break;

                case "Ibishu Wigeon":
                    text = "wigeon";
                    break;

                case "Soliad Lansdale":
                    text = "lansdale";
                    break;

                case "Soliad Wendover":
                    text = "wendover";
                    break;

                case "SP Dunekicker":
                    text = "racetruck";
                    break;

                case "Wentward DT40L":
                    text = "citybus";
                    break;
            }

            string path = System.IO.Path.Combine(dirrr, text);
            string Picco = path;

            string endpath = System.IO.Path.Combine(path, text);

            combobox = endpath;
        }

        public async void page1dalee_Click(object sender, RoutedEventArgs e)
        {
            if (combobox == null)
            {
                ContentDialog autoerror = new ContentDialog
                {
                    Title = "ошибка перехода на следуйщий этап",
                    Content = "поле выбора авто пустое. Пожалуйста, выберите автомобиль.",
                    CloseButtonText = "OK",                   
                };
                autoerror.XamlRoot = page1dalee.XamlRoot;

                ContentDialogResult result = await autoerror.ShowAsync();

            }
            else
            {
                Directory.CreateDirectory(combobox);
                ContentFrame.Navigate(typeof(downloadinguv), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
                ProgressOnTop.Value = 37;
            }
        }

        private void ProgressBarOn_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
           
        }

    }
}
