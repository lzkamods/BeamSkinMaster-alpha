using BeamSkinMaster.classes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using System.Security.Permissions;
using System.Security;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PackingPage : Page
    {
        public PackingPage()
        {
            this.InitializeComponent();
            MainWindow.progressBar.ShowPaused = true;
        }

        string pngpath = MainWindow.pppth + @"\" + MainWindow.endtext + "_skin_SKINNAME.png";
        string path = System.IO.Path.Combine(pathes.dir, MainWindow.endtext);


        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            File.Delete(pngpath);
            Directory.CreateDirectory(path);

            await Task.Delay(3000);
            waittext.Text = "������ ��� � ZIP";

            string source = Path.Combine(pathes.dir, "vehicles");
            string pathh = Path.Combine(pathes.dir, MainWindow.endtext, "vehicles");
            string autopath = Path.Combine(pathh, MainWindow.endtext);
            string intpath = Path.Combine(pathh, MainWindow.endtext, ChoosingNamePage.inttxt);
            string pcfile = ChoosingNamePage.inttxt + ".pc";
            string jbeamfile = MainWindow.endtext + ".jbeam";
            string ddsfile = MainWindow.endtext + "_skin_" + ChoosingNamePage.inttxt + ".dds";
            string jsonfile = "info_" + ChoosingNamePage.inttxt + ".json";
            string matspath = Path.Combine(pathes.dir, "vehicles", MainWindow.endtext, ChoosingNamePage.inttxt, "materials.json");
            string matdspath = Path.Combine(intpath, "materials.json");
            string jbeamspath = Path.Combine(pathes.dir, "vehicles", MainWindow.endtext, ChoosingNamePage.inttxt, jbeamfile);
            string jbeamdspath = Path.Combine(intpath, jbeamfile);
            string ddsspath = Path.Combine(pathes.dir, "vehicles", MainWindow.endtext, ChoosingNamePage.inttxt, ddsfile);
            string ddsdspath = Path.Combine(intpath, ddsfile);
            string pcspath = Path.Combine(pathes.dir, "vehicles", MainWindow.endtext, pcfile);
            string jsonspath = Path.Combine(pathes.dir, "vehicles", MainWindow.endtext, jsonfile);
            string pcdspath = Path.Combine(autopath, pcfile);
            string jsondspath = Path.Combine(autopath, jsonfile);
            string zippath = Path.Combine(source, ChoosingNamePage.inttxt + ".zip");
            string zipspath = Path.Combine(pathes.dir, MainWindow.endtext);

            try
            {
                // ��������� ������������� �������� �����
                if (Directory.Exists(source))
                {

                    Directory.CreateDirectory(pathh);
                    Directory.CreateDirectory(autopath);
                    Directory.CreateDirectory(intpath);
                    File.Copy(pcspath, pcdspath);
                    File.Copy(jsonspath, jsondspath);
                    File.Copy(matspath, matdspath);
                    File.Copy(jbeamspath, jbeamdspath);
                    File.Copy(ddsspath, ddsdspath);
                    ZipFile.CreateFromDirectory(zipspath, zippath);
                    ContentDialog finish = new ContentDialog
                    {
                        Title = "����������� �������",
                        Content = "��� ����������� ������� ��",
                        CloseButtonText = "OK",
                    };
                    finish.XamlRoot = waittext.XamlRoot;
                    finish.CloseButtonClick += (s, args) =>
                    {
                        ContentFrame.Navigate(typeof(FinishPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
                        MainWindow.progressBar.Value = 100;
                    };

                    ContentDialogResult result = await finish.ShowAsync();
                }
                else
                {
                    ContentDialog na = new ContentDialog
                    {
                        Title = "������ ��� ����������",
                        Content = "���������� ����������� �����, ��� ��� ��� �� ����������",
                        CloseButtonText = "OK",
                    };
                    na.XamlRoot = waittext.XamlRoot;

                    ContentDialogResult result = await na.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                ContentDialog error = new ContentDialog
                {
                    Title = "������ ��� ����������",
                    Content = $"���������� ����������� �����, �� �������: {ex.Message}",
                    CloseButtonText = "OK",
                };
                error.XamlRoot = waittext.XamlRoot;

                error.CloseButtonClick += (s, args) =>
                {
                    ContentFrame.Navigate(typeof(ChoosingNamePage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft });
                };

                ContentDialogResult result = await error.ShowAsync();
            }
        }
    }
}
