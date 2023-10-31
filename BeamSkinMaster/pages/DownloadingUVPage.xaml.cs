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
using Windows.Storage.Pickers;
using Windows.Storage;
using System.Diagnostics;
using Microsoft.UI.Xaml.Media.Animation;
using BeamSkinMaster.pages;
using Microsoft.UI.Composition.SystemBackdrops;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DownloadingUVPage : Page
    {
        public DownloadingUVPage()
        {
            this.InitializeComponent();
        }


        private async void downloadbutton_Click(object sender, RoutedEventArgs e)
        {
            if (MainPage.endtext == "autobello")
            {
                try
                {
                    Uri autobelloUri = new($"ms-appx:///Assets/uv's/autobello_skin_SKINNAME.png");
                    StorageFile autobelloFile = await StorageFile.GetFileFromApplicationUriAsync(autobelloUri);

                    string autobellopath = MainPage.pppth;
                    StorageFolder autobelloendpath = await StorageFolder.GetFolderFromPathAsync(autobellopath);

                    await autobelloFile.CopyAsync(autobelloendpath);

                    Process.Start("explorer.exe", autobellopath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "midtruck")
            {
                try
                {
                    Uri midtruckUri = new($"ms-appx:///Assets/uv's/midtruck_main_skin_uv.png");
                    StorageFile midtruckFile = await StorageFile.GetFileFromApplicationUriAsync(midtruckUri);

                    string midtruckpath = MainPage.pppth;
                    StorageFolder midtruckendpath = await StorageFolder.GetFolderFromPathAsync(midtruckpath);

                    await midtruckFile.CopyAsync(midtruckendpath);

                    Process.Start("explorer.exe", midtruckpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "bastion")
            {
                try
                {
                    Uri bastionUri = new($"ms-appx:///Assets/uv's/bastion_skin_SKINNAME.png");
                    StorageFile bastionFile = await StorageFile.GetFileFromApplicationUriAsync(bastionUri);

                    string bastionpath = MainPage.pppth;
                    StorageFolder bastionendpath = await StorageFolder.GetFolderFromPathAsync(bastionpath);

                    await bastionFile.CopyAsync(bastionendpath);

                    Process.Start("explorer.exe", bastionpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }

            }

            if (MainPage.endtext == "legran")
            {
                try
                {
                    Uri legranUri = new($"ms-appx:///Assets/uv's/legran_skin_SKINNAME.png");
                    StorageFile legranFile = await StorageFile.GetFileFromApplicationUriAsync(legranUri);

                    string legranpath = MainPage.pppth;
                    StorageFolder legranendpath = await StorageFolder.GetFolderFromPathAsync(legranpath);

                    await legranFile.CopyAsync(legranendpath);

                    Process.Start("explorer.exe", legranpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "burnside")
            {
                try
                {
                    Uri burnsideUri = new($"ms-appx:///Assets/uv's/burnside_skin_SKINNAME.png");
                    StorageFile burnsideFile = await StorageFile.GetFileFromApplicationUriAsync(burnsideUri);

                    string burnsidepath = MainPage.pppth;
                    StorageFolder burnsideendpath = await StorageFolder.GetFolderFromPathAsync(burnsidepath);

                    await burnsideFile.CopyAsync(burnsideendpath);

                    Process.Start("explorer.exe", burnsidepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "vivace")
            {
                try
                {
                    Uri vivaceUri = new($"ms-appx:///Assets/uv's/vivace_skin_SKINNAME.png");
                    StorageFile vivaceFile = await StorageFile.GetFileFromApplicationUriAsync(vivaceUri);

                    string vivacepath = MainPage.pppth;
                    StorageFolder vivaceendpath = await StorageFolder.GetFolderFromPathAsync(vivacepath);

                    await vivaceFile.CopyAsync(vivaceendpath);

                    Process.Start("explorer.exe", vivacepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "bolide")
            {
                try
                {
                    Uri bolideUri = new($"ms-appx:///Assets/uv's/bolide_skin_SKINNAME.png");
                    StorageFile bolideFile = await StorageFile.GetFileFromApplicationUriAsync(bolideUri);

                    string bolidepath = MainPage.pppth;
                    StorageFolder bolideendpath = await StorageFolder.GetFolderFromPathAsync(bolidepath);

                    await bolideFile.CopyAsync(bolideendpath);

                    Process.Start("explorer.exe", bolidepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "scintilla")
            {
                try
                {
                    Uri scintillaUri = new($"ms-appx:///Assets/uv's/scintilla_skin_SKINNAME.png");
                    StorageFile scintillaFile = await StorageFile.GetFileFromApplicationUriAsync(scintillaUri);

                    string scintillapath = MainPage.pppth;
                    StorageFolder scintillaendpath = await StorageFolder.GetFolderFromPathAsync(scintillapath);

                    await scintillaFile.CopyAsync(scintillaendpath);

                    Process.Start("explorer.exe", scintillapath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "etk800")
            {
                try
                {
                Uri etk800Uri = new($"ms-appx:///Assets/uv's/etk800_skin_SKINNAME.png");
                StorageFile etk800File = await StorageFile.GetFileFromApplicationUriAsync(etk800Uri);

                string etk800path = MainPage.pppth;
                StorageFolder etk800endpath = await StorageFolder.GetFolderFromPathAsync(etk800path);

                await etk800File.CopyAsync(etk800endpath);

                Process.Start("explorer.exe", etk800path);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "etki")
            {
                try
                {
                Uri etkiUri = new($"ms-appx:///Assets/uv's/etki_skin_SKINNAME.png");
                StorageFile etkiFile = await StorageFile.GetFileFromApplicationUriAsync(etkiUri);

                string etkipath = MainPage.pppth;
                StorageFolder etkiendpath = await StorageFolder.GetFolderFromPathAsync(etkipath);

                await etkiFile.CopyAsync(etkiendpath);

                Process.Start("explorer.exe", etkipath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "etkc")
            {
                try
                {
                Uri etkcUri = new($"ms-appx:///Assets/uv's/etkc_skin_SKINNAME.png");
                StorageFile etkcFile = await StorageFile.GetFileFromApplicationUriAsync(etkcUri);

                string etkcpath = MainPage.pppth;
                StorageFolder etkcendpath = await StorageFolder.GetFolderFromPathAsync(etkcpath);

                await etkcFile.CopyAsync(etkcendpath);

                Process.Start("explorer.exe", etkcpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "barstow")
            {
                try
                {
                Uri barstowUri = new($"ms-appx:///Assets/uv's/barstow_skin_SKINNAME.png");
                StorageFile barstowFile = await StorageFile.GetFileFromApplicationUriAsync(barstowUri);

                string barstowpath = MainPage.pppth;
                StorageFolder barstowendpath = await StorageFolder.GetFolderFromPathAsync(barstowpath);

                await barstowFile.CopyAsync(barstowendpath);

                Process.Start("explorer.exe", barstowpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "bluebuck")
            {
                try
                {
                Uri bluebuckUri = new($"ms-appx:///Assets/uv's/bluebuck_skin_SKINNAME.png");
                StorageFile bluebuckFile = await StorageFile.GetFileFromApplicationUriAsync(bluebuckUri);

                string bluebuckpath = MainPage.pppth;
                StorageFolder bluebuckendpath = await StorageFolder.GetFolderFromPathAsync(bluebuckpath);

                await bluebuckFile.CopyAsync(bluebuckendpath);

                Process.Start("explorer.exe", bluebuckpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "pickup")
            {
                try
                {
                Uri pickupUri = new($"ms-appx:///Assets/uv's/pickup_skin_SKINNAME.png");
                StorageFile pickupFile = await StorageFile.GetFileFromApplicationUriAsync(pickupUri);

                string pickuppath = MainPage.pppth;
                StorageFolder pickupendpath = await StorageFolder.GetFolderFromPathAsync(pickuppath);

                await pickupFile.CopyAsync(pickupendpath);

                Process.Start("explorer.exe", pickuppath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "fullsize")
            {
                try
                {
                Uri fullsizeUri = new($"ms-appx:///Assets/uv's/fullsize_skin_SKINNAME.png");
                StorageFile fullsizeFile = await StorageFile.GetFileFromApplicationUriAsync(fullsizeUri);

                string fullsizepath = MainPage.pppth;
                StorageFolder fullsizeendpath = await StorageFolder.GetFolderFromPathAsync(fullsizepath);

                await fullsizeFile.CopyAsync(fullsizeendpath);

                Process.Start("explorer.exe", fullsizepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "van")
            {
                try
                {
                Uri vanUri = new($"ms-appx:///Assets/uv's/van_skin_SKINNAME.png");
                StorageFile vanFile = await StorageFile.GetFileFromApplicationUriAsync(vanUri);

                string vanpath = MainPage.pppth;
                StorageFolder vanendpath = await StorageFolder.GetFolderFromPathAsync(vanpath);

                await vanFile.CopyAsync(vanendpath);

                Process.Start("explorer.exe", vanpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "roamer")
            {
                try
                {
                Uri roamerUri = new($"ms-appx:///Assets/uv's/roamer_skin_SKINNAME.png");
                StorageFile roamerFile = await StorageFile.GetFileFromApplicationUriAsync(roamerUri);

                string roamerpath = MainPage.pppth;
                StorageFolder roamerendpath = await StorageFolder.GetFolderFromPathAsync(roamerpath);

                await roamerFile.CopyAsync(roamerendpath);

                Process.Start("explorer.exe", roamerpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "semi")
            {
                try
                {
                Uri semiUri = new($"ms-appx:///Assets/uv's/semi_skin_SKINNAME.png");
                StorageFile semiFile = await StorageFile.GetFileFromApplicationUriAsync(semiUri);

                string semipath = MainPage.pppth;
                StorageFolder semiendpath = await StorageFolder.GetFolderFromPathAsync(semipath);

                await semiFile.CopyAsync(semiendpath);

                Process.Start("explorer.exe", semipath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "sbr")
            {
                try
                {
                Uri sbrUri = new($"ms-appx:///Assets/uv's/sbr_skin_SKINNAME.png");
                StorageFile sbrFile = await StorageFile.GetFileFromApplicationUriAsync(sbrUri);

                string sbrpath = MainPage.pppth;
                StorageFolder sbrendpath = await StorageFolder.GetFolderFromPathAsync(sbrpath);

                await sbrFile.CopyAsync(sbrendpath);

                Process.Start("explorer.exe", sbrpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "sunburst")
            {
                try
                {
                Uri sunburstUri = new($"ms-appx:///Assets/uv's/sunburst_skin_SKINNAME.png");
                StorageFile sunburstFile = await StorageFile.GetFileFromApplicationUriAsync(sunburstUri);

                string sunburstpath = MainPage.pppth;
                StorageFolder sunburstendpath = await StorageFolder.GetFolderFromPathAsync(sunburstpath);

                await sunburstFile.CopyAsync(sunburstendpath);

                Process.Start("explorer.exe", sunburstpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "coupe")
            {
                try
                {
                Uri coupeUri = new($"ms-appx:///Assets/uv's/coupe_skin_SKINNAME.png");
                StorageFile coupeFile = await StorageFile.GetFileFromApplicationUriAsync(coupeUri);

                string coupepath = MainPage.pppth;
                StorageFolder coupeendpath = await StorageFolder.GetFolderFromPathAsync(coupepath);

                await coupeFile.CopyAsync(coupeendpath);

                Process.Start("explorer.exe", coupepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "covet")
            {
                try
                {
                Uri covetUri = new($"ms-appx:///Assets/uv's/covet_skin_SKINNAME.png");
                StorageFile covetFile = await StorageFile.GetFileFromApplicationUriAsync(covetUri);

                string covetpath = MainPage.pppth;
                StorageFolder covetendpath = await StorageFolder.GetFolderFromPathAsync(covetpath);

                await covetFile.CopyAsync(covetendpath);

                Process.Start("explorer.exe", covetpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "hopper")
            {
                try
                {
                Uri hopperUri = new($"ms-appx:///Assets/uv's/hopper_skin_SKINNAME.png");
                StorageFile hopperFile = await StorageFile.GetFileFromApplicationUriAsync(hopperUri);

                string hopperpath = MainPage.pppth;
                StorageFolder hopperendpath = await StorageFolder.GetFolderFromPathAsync(hopperpath);

                await hopperFile.CopyAsync(hopperendpath);

                Process.Start("explorer.exe", hopperpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "miramar")
            {
                try
                {
                Uri miramarUri = new($"ms-appx:///Assets/uv's/miramar_skin_SKINNAME.png");
                StorageFile miramarFile = await StorageFile.GetFileFromApplicationUriAsync(miramarUri);

                string miramarpath = MainPage.pppth;
                StorageFolder miramarendpath = await StorageFolder.GetFolderFromPathAsync(miramarpath);

                await miramarFile.CopyAsync(miramarendpath);

                Process.Start("explorer.exe", miramarpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "pessima")
            {
                try
                {
                Uri pessimaUri = new($"ms-appx:///Assets/uv's/pessima_skin_SKINNAME.png");
                StorageFile pessimaFile = await StorageFile.GetFileFromApplicationUriAsync(pessimaUri);

                string pessimapath = MainPage.pppth;
                StorageFolder pessimaendpath = await StorageFolder.GetFolderFromPathAsync(pessimapath);

                await pessimaFile.CopyAsync(pessimaendpath);

                Process.Start("explorer.exe", pessimapath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "midsize")
            {
                try
                {
                Uri midsizeUri = new($"ms-appx:///Assets/uv's/midsize_skin_SKINNAME.png");
                StorageFile midsizeFile = await StorageFile.GetFileFromApplicationUriAsync(midsizeUri);

                string midsizepath = MainPage.pppth;
                StorageFolder midsizeendpath = await StorageFolder.GetFolderFromPathAsync(midsizepath);

                await midsizeFile.CopyAsync(midsizeendpath);

                Process.Start("explorer.exe", midsizepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "pigeon")
            {
                try
                {
                Uri pigeonUri = new($"ms-appx:///Assets/uv's/pigeon_skin_SKINNAME.png");
                StorageFile pigeonFile = await StorageFile.GetFileFromApplicationUriAsync(pigeonUri);

                string pigeonpath = MainPage.pppth;
                StorageFolder pigeonendpath = await StorageFolder.GetFolderFromPathAsync(pigeonpath);

                await pigeonFile.CopyAsync(pigeonendpath);

                Process.Start("explorer.exe", pigeonpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "wigeon")
            {
                try
                {
                Uri wigeonUri = new($"ms-appx:///Assets/uv's/wigeon_skin_SKINNAME.png");
                StorageFile wigeonFile = await StorageFile.GetFileFromApplicationUriAsync(wigeonUri);

                string wigeonpath = MainPage.pppth;
                StorageFolder wigeonendpath = await StorageFolder.GetFolderFromPathAsync(wigeonpath);

                await wigeonFile.CopyAsync(wigeonendpath);

                Process.Start("explorer.exe", wigeonpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "lansdale")
            {
                try
                {
                Uri lansdaleUri = new($"ms-appx:///Assets/uv's/lansdale_skin_SKINNAME.png");
                StorageFile lansdaleFile = await StorageFile.GetFileFromApplicationUriAsync(lansdaleUri);

                string lansdalepath = MainPage.pppth;
                StorageFolder lansdaleendpath = await StorageFolder.GetFolderFromPathAsync(lansdalepath);

                await lansdaleFile.CopyAsync(lansdaleendpath);

                Process.Start("explorer.exe", lansdalepath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "wendover")
            {
                try
                {
                Uri wendoverUri = new($"ms-appx:///Assets/uv's/wendover_skin_SKINNAME.png");
                StorageFile wendoverFile = await StorageFile.GetFileFromApplicationUriAsync(wendoverUri);

                string wendoverpath = MainPage.pppth;
                StorageFolder wendoverendpath = await StorageFolder.GetFolderFromPathAsync(wendoverpath);

                await wendoverFile.CopyAsync(wendoverendpath);

                Process.Start("explorer.exe", wendoverpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "racetruck")
            {
                try
                {
                Uri racetruckUri = new($"ms-appx:///Assets/uv's/racetruck_skin_SKINNAME.png");
                StorageFile racetruckFile = await StorageFile.GetFileFromApplicationUriAsync(racetruckUri);

                string racetruckpath = MainPage.pppth;
                StorageFolder racetruckendpath = await StorageFolder.GetFolderFromPathAsync(racetruckpath);

                await racetruckFile.CopyAsync(racetruckendpath);

                Process.Start("explorer.exe", racetruckpath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }

            if (MainPage.endtext == "citybus")
            {
                try
                {
                Uri citybusUri = new($"ms-appx:///Assets/uv's/citybus_skin_SKINNAME.png");
                StorageFile citybusFile = await StorageFile.GetFileFromApplicationUriAsync(citybusUri);

                string citybuspath = MainPage.pppth;
                StorageFolder citybusendpath = await StorageFolder.GetFolderFromPathAsync(citybuspath);

                await citybusFile.CopyAsync(citybusendpath);

                Process.Start("explorer.exe", citybuspath);
                }
                catch (Exception ex)
                {
                    ContentDialog autoerror = new ContentDialog
                    {
                        Title = "Ошибка загрузки изображения",
                        Content = "Файл уже существует. Пожалуйста, нажмите Далее",
                        CloseButtonText = "OK",
                    };
                    autoerror.XamlRoot = downloadbutton.XamlRoot;

                    ContentDialogResult result = await autoerror.ShowAsync();
                }
            }
        }

        private void dalee2btn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(uploadingUVPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            downloadbutton.IsEnabled = false;
            MainPage.progressBar.Value = 50;
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(MainPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromLeft });
            MainPage.progressBar.Value = 27;
        }
    }
}
