using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using BeamSkinMaster.classes;
using Microsoft.UI.Xaml.Media.Animation;
using Windows.Graphics;
using Microsoft.UI.Windowing;
using Microsoft.Windows.ApplicationModel.Resources;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            progressBar = ProgressOnTop;
            MainTitleBar = AppTitleBar;
            Directory.CreateDirectory(pathes.pth);
        }

        public static string endtext;
        public static string endpathh;
        private string combobox;
        public static string intauto;
        public static string pppth;
        public static ProgressBar progressBar { get; set; }
        public static Grid MainTitleBar { get; set; }
        public XamlRoot XamlRoot { get; set; }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Combobox1.SelectedIndex;
            string text = Combobox1.Items[index].ToString();

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

            string path = System.IO.Path.Combine(pathes.dirrr, text);
            string endpath = System.IO.Path.Combine(path, text);

            pppth = path;
            combobox = path;
            endtext = text;
            intauto = endtext;
            endpathh = endpath;
        }


        public async void page1dalee_Click(object sender, RoutedEventArgs e)
        {
            var resourceLoader = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader();

            if (combobox == null)
            {
                ContentDialog autoerror = new ContentDialog
                {
                    Title = CntDlgTitle.Text,
                    Content = CntDlgCnt.Text,
                    CloseButtonText = "OK",
                };
                autoerror.XamlRoot = page1dalee.XamlRoot;

                ContentDialogResult result = await autoerror.ShowAsync();

            }
            else
            {
                Directory.CreateDirectory(combobox);
                ContentFrame.Navigate(typeof(DownloadingUVPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
                Combobox1.IsEnabled = false;
                ProgressOnTop.Value = 37;
            }
        }

        private void ProgressBarOn_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void settingbtn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(SettingsPage), null, new DrillInNavigationTransitionInfo());
        }
    }
}
