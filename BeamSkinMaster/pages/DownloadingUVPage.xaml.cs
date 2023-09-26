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
            if (MainWindow.endtext == "autobello")
            {
                Uri autobelloUri = new($"ms-appx:///Assets/autobello_skin_UVs.png");
                StorageFile autobelloFile = await StorageFile.GetFileFromApplicationUriAsync(autobelloUri);

                string autobellopath = MainWindow.pppth;
                StorageFolder autobelloendpath = await StorageFolder.GetFolderFromPathAsync(autobellopath);

                await autobelloFile.CopyAsync(autobelloendpath);

                Process.Start("explorer.exe", autobellopath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "midtruck")
            {
                Uri midtruckUri = new($"ms-appx:///Assets/uv's/midtruck_main_skin_uv.png");
                StorageFile midtruckFile = await StorageFile.GetFileFromApplicationUriAsync(midtruckUri);

                string midtruckpath = MainWindow.pppth;
                StorageFolder midtruckendpath = await StorageFolder.GetFolderFromPathAsync(midtruckpath);

                await midtruckFile.CopyAsync(midtruckendpath);

                Process.Start("explorer.exe", midtruckpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "bastion")
            {
                Uri bastionUri = new($"ms-appx:///Assets/uv's/bastion_skin_SKINNAME.png");
                StorageFile bastionFile = await StorageFile.GetFileFromApplicationUriAsync(bastionUri);

                string bastionpath = MainWindow.pppth;
                StorageFolder bastionendpath = await StorageFolder.GetFolderFromPathAsync(bastionpath);

                await bastionFile.CopyAsync(bastionendpath);

                Process.Start("explorer.exe", bastionpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "legran")
            {
                Uri legranUri = new($"ms-appx:///Assets/uv's/legran_skin_SKINNAME.png");
                StorageFile legranFile = await StorageFile.GetFileFromApplicationUriAsync(legranUri);

                string legranpath = MainWindow.pppth;
                StorageFolder legranendpath = await StorageFolder.GetFolderFromPathAsync(legranpath);

                await legranFile.CopyAsync(legranendpath);

                Process.Start("explorer.exe", legranpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "burnside")
            {
                Uri burnsideUri = new($"ms-appx:///Assets/uv's/burnside_skin_SKINNAME.png");
                StorageFile burnsideFile = await StorageFile.GetFileFromApplicationUriAsync(burnsideUri);

                string burnsidepath = MainWindow.pppth;
                StorageFolder burnsideendpath = await StorageFolder.GetFolderFromPathAsync(burnsidepath);

                await burnsideFile.CopyAsync(burnsideendpath);

                Process.Start("explorer.exe", burnsidepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "vivace")
            {
                Uri vivaceUri = new($"ms-appx:///Assets/uv's/vivace_skin_SKINNAME.png");
                StorageFile vivaceFile = await StorageFile.GetFileFromApplicationUriAsync(vivaceUri);

                string vivacepath = MainWindow.pppth;
                StorageFolder vivaceendpath = await StorageFolder.GetFolderFromPathAsync(vivacepath);

                await vivaceFile.CopyAsync(vivaceendpath);

                Process.Start("explorer.exe", vivacepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "bolide")
            {
                Uri bolideUri = new($"ms-appx:///Assets/uv's/bolide_skin_SKINNAME.png");
                StorageFile bolideFile = await StorageFile.GetFileFromApplicationUriAsync(bolideUri);

                string bolidepath = MainWindow.pppth;
                StorageFolder bolideendpath = await StorageFolder.GetFolderFromPathAsync(bolidepath);

                await bolideFile.CopyAsync(bolideendpath);

                Process.Start("explorer.exe", bolidepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "scintilla")
            {
                Uri scintillaUri = new($"ms-appx:///Assets/uv's/scintilla_skin_SKINNAME.png");
                StorageFile scintillaFile = await StorageFile.GetFileFromApplicationUriAsync(scintillaUri);

                string scintillapath = MainWindow.pppth;
                StorageFolder scintillaendpath = await StorageFolder.GetFolderFromPathAsync(scintillapath);

                await scintillaFile.CopyAsync(scintillaendpath);

                Process.Start("explorer.exe", scintillapath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "etk800")
            {
                Uri etk800Uri = new($"ms-appx:///Assets/uv's/etk800_skin_SKINNAME.png");
                StorageFile etk800File = await StorageFile.GetFileFromApplicationUriAsync(etk800Uri);

                string etk800path = MainWindow.pppth;
                StorageFolder etk800endpath = await StorageFolder.GetFolderFromPathAsync(etk800path);

                await etk800File.CopyAsync(etk800endpath);

                Process.Start("explorer.exe", etk800path);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "etki")
            {
                Uri etkiUri = new($"ms-appx:///Assets/uv's/etki_skin_SKINNAME.png");
                StorageFile etkiFile = await StorageFile.GetFileFromApplicationUriAsync(etkiUri);

                string etkipath = MainWindow.pppth;
                StorageFolder etkiendpath = await StorageFolder.GetFolderFromPathAsync(etkipath);

                await etkiFile.CopyAsync(etkiendpath);

                Process.Start("explorer.exe", etkipath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "etkc")
            {
                Uri etkcUri = new($"ms-appx:///Assets/uv's/etkc_skin_SKINNAME.png");
                StorageFile etkcFile = await StorageFile.GetFileFromApplicationUriAsync(etkcUri);

                string etkcpath = MainWindow.pppth;
                StorageFolder etkcendpath = await StorageFolder.GetFolderFromPathAsync(etkcpath);

                await etkcFile.CopyAsync(etkcendpath);

                Process.Start("explorer.exe", etkcpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "barstow")
            {
                Uri barstowUri = new($"ms-appx:///Assets/uv's/barstow_skin_SKINNAME.png");
                StorageFile barstowFile = await StorageFile.GetFileFromApplicationUriAsync(barstowUri);

                string barstowpath = MainWindow.pppth;
                StorageFolder barstowendpath = await StorageFolder.GetFolderFromPathAsync(barstowpath);

                await barstowFile.CopyAsync(barstowendpath);

                Process.Start("explorer.exe", barstowpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "bluebuck")
            {
                Uri bluebuckUri = new($"ms-appx:///Assets/uv's/bluebuck_skin_SKINNAME.png");
                StorageFile bluebuckFile = await StorageFile.GetFileFromApplicationUriAsync(bluebuckUri);

                string bluebuckpath = MainWindow.pppth;
                StorageFolder bluebuckendpath = await StorageFolder.GetFolderFromPathAsync(bluebuckpath);

                await bluebuckFile.CopyAsync(bluebuckendpath);

                Process.Start("explorer.exe", bluebuckpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "pickup")
            {
                Uri pickupUri = new($"ms-appx:///Assets/uv's/pickup_skin_SKINNAME.png");
                StorageFile pickupFile = await StorageFile.GetFileFromApplicationUriAsync(pickupUri);

                string pickuppath = MainWindow.pppth;
                StorageFolder pickupendpath = await StorageFolder.GetFolderFromPathAsync(pickuppath);

                await pickupFile.CopyAsync(pickupendpath);

                Process.Start("explorer.exe", pickuppath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "fullsize")
            {
                Uri fullsizeUri = new($"ms-appx:///Assets/uv's/fullsize_skin_SKINNAME.png");
                StorageFile fullsizeFile = await StorageFile.GetFileFromApplicationUriAsync(fullsizeUri);

                string fullsizepath = MainWindow.pppth;
                StorageFolder fullsizeendpath = await StorageFolder.GetFolderFromPathAsync(fullsizepath);

                await fullsizeFile.CopyAsync(fullsizeendpath);

                Process.Start("explorer.exe", fullsizepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "van")
            {
                Uri vanUri = new($"ms-appx:///Assets/uv's/van_skin_SKINNAME.png");
                StorageFile vanFile = await StorageFile.GetFileFromApplicationUriAsync(vanUri);

                string vanpath = MainWindow.pppth;
                StorageFolder vanendpath = await StorageFolder.GetFolderFromPathAsync(vanpath);

                await vanFile.CopyAsync(vanendpath);

                Process.Start("explorer.exe", vanpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "roamer")
            {
                Uri roamerUri = new($"ms-appx:///Assets/uv's/roamer_skin_SKINNAME.png");
                StorageFile roamerFile = await StorageFile.GetFileFromApplicationUriAsync(roamerUri);

                string roamerpath = MainWindow.pppth;
                StorageFolder roamerendpath = await StorageFolder.GetFolderFromPathAsync(roamerpath);

                await roamerFile.CopyAsync(roamerendpath);

                Process.Start("explorer.exe", roamerpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "semi")
            {
                Uri semiUri = new($"ms-appx:///Assets/uv's/semi_skin_SKINNAME.png");
                StorageFile semiFile = await StorageFile.GetFileFromApplicationUriAsync(semiUri);

                string semipath = MainWindow.pppth;
                StorageFolder semiendpath = await StorageFolder.GetFolderFromPathAsync(semipath);

                await semiFile.CopyAsync(semiendpath);

                Process.Start("explorer.exe", semipath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "sbr")
            {
                Uri sbrUri = new($"ms-appx:///Assets/uv's/sbr_skin_SKINNAME.png");
                StorageFile sbrFile = await StorageFile.GetFileFromApplicationUriAsync(sbrUri);

                string sbrpath = MainWindow.pppth;
                StorageFolder sbrendpath = await StorageFolder.GetFolderFromPathAsync(sbrpath);

                await sbrFile.CopyAsync(sbrendpath);

                Process.Start("explorer.exe", sbrpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "sunburst")
            {
                Uri sunburstUri = new($"ms-appx:///Assets/uv's/sunburst_skin_SKINNAME.png");
                StorageFile sunburstFile = await StorageFile.GetFileFromApplicationUriAsync(sunburstUri);

                string sunburstpath = MainWindow.pppth;
                StorageFolder sunburstendpath = await StorageFolder.GetFolderFromPathAsync(sunburstpath);

                await sunburstFile.CopyAsync(sunburstendpath);

                Process.Start("explorer.exe", sunburstpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "coupe")
            {
                Uri coupeUri = new($"ms-appx:///Assets/uv's/coupe_skin_SKINNAME.png");
                StorageFile coupeFile = await StorageFile.GetFileFromApplicationUriAsync(coupeUri);

                string coupepath = MainWindow.pppth;
                StorageFolder coupeendpath = await StorageFolder.GetFolderFromPathAsync(coupepath);

                await coupeFile.CopyAsync(coupeendpath);

                Process.Start("explorer.exe", coupepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "covet")
            {
                Uri covetUri = new($"ms-appx:///Assets/uv's/covet_skin_SKINNAME.png");
                StorageFile covetFile = await StorageFile.GetFileFromApplicationUriAsync(covetUri);

                string covetpath = MainWindow.pppth;
                StorageFolder covetendpath = await StorageFolder.GetFolderFromPathAsync(covetpath);

                await covetFile.CopyAsync(covetendpath);

                Process.Start("explorer.exe", covetpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "hopper")
            {
                Uri hopperUri = new($"ms-appx:///Assets/uv's/hopper_skin_SKINNAME.png");
                StorageFile hopperFile = await StorageFile.GetFileFromApplicationUriAsync(hopperUri);

                string hopperpath = MainWindow.pppth;
                StorageFolder hopperendpath = await StorageFolder.GetFolderFromPathAsync(hopperpath);

                await hopperFile.CopyAsync(hopperendpath);

                Process.Start("explorer.exe", hopperpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "miramar")
            {
                Uri miramarUri = new($"ms-appx:///Assets/uv's/miramar_skin_SKINNAME.png");
                StorageFile miramarFile = await StorageFile.GetFileFromApplicationUriAsync(miramarUri);

                string miramarpath = MainWindow.pppth;
                StorageFolder miramarendpath = await StorageFolder.GetFolderFromPathAsync(miramarpath);

                await miramarFile.CopyAsync(miramarendpath);

                Process.Start("explorer.exe", miramarpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "pessima")
            {
                Uri pessimaUri = new($"ms-appx:///Assets/uv's/pessima_skin_SKINNAME.png");
                StorageFile pessimaFile = await StorageFile.GetFileFromApplicationUriAsync(pessimaUri);

                string pessimapath = MainWindow.pppth;
                StorageFolder pessimaendpath = await StorageFolder.GetFolderFromPathAsync(pessimapath);

                await pessimaFile.CopyAsync(pessimaendpath);

                Process.Start("explorer.exe", pessimapath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "midsize")
            {
                Uri midsizeUri = new($"ms-appx:///Assets/uv's/midsize_skin_SKINNAME.png");
                StorageFile midsizeFile = await StorageFile.GetFileFromApplicationUriAsync(midsizeUri);

                string midsizepath = MainWindow.pppth;
                StorageFolder midsizeendpath = await StorageFolder.GetFolderFromPathAsync(midsizepath);

                await midsizeFile.CopyAsync(midsizeendpath);

                Process.Start("explorer.exe", midsizepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "pigeon")
            {
                Uri pigeonUri = new($"ms-appx:///Assets/uv's/pigeon_skin_SKINNAME.png");
                StorageFile pigeonFile = await StorageFile.GetFileFromApplicationUriAsync(pigeonUri);

                string pigeonpath = MainWindow.pppth;
                StorageFolder pigeonendpath = await StorageFolder.GetFolderFromPathAsync(pigeonpath);

                await pigeonFile.CopyAsync(pigeonendpath);

                Process.Start("explorer.exe", pigeonpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "wigeon")
            {
                Uri wigeonUri = new($"ms-appx:///Assets/uv's/wigeon_skin_SKINNAME.png");
                StorageFile wigeonFile = await StorageFile.GetFileFromApplicationUriAsync(wigeonUri);

                string wigeonpath = MainWindow.pppth;
                StorageFolder wigeonendpath = await StorageFolder.GetFolderFromPathAsync(wigeonpath);

                await wigeonFile.CopyAsync(wigeonendpath);

                Process.Start("explorer.exe", wigeonpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "lansdale")
            {
                Uri lansdaleUri = new($"ms-appx:///Assets/uv's/lansdale_skin_SKINNAME.png");
                StorageFile lansdaleFile = await StorageFile.GetFileFromApplicationUriAsync(lansdaleUri);

                string lansdalepath = MainWindow.pppth;
                StorageFolder lansdaleendpath = await StorageFolder.GetFolderFromPathAsync(lansdalepath);

                await lansdaleFile.CopyAsync(lansdaleendpath);

                Process.Start("explorer.exe", lansdalepath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "wendover")
            {
                Uri wendoverUri = new($"ms-appx:///Assets/uv's/wendover_skin_SKINNAME.png");
                StorageFile wendoverFile = await StorageFile.GetFileFromApplicationUriAsync(wendoverUri);

                string wendoverpath = MainWindow.pppth;
                StorageFolder wendoverendpath = await StorageFolder.GetFolderFromPathAsync(wendoverpath);

                await wendoverFile.CopyAsync(wendoverendpath);

                Process.Start("explorer.exe", wendoverpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "racetruck")
            {
                Uri racetruckUri = new($"ms-appx:///Assets/uv's/racetruck_skin_SKINNAME.png");
                StorageFile racetruckFile = await StorageFile.GetFileFromApplicationUriAsync(racetruckUri);

                string racetruckpath = MainWindow.pppth;
                StorageFolder racetruckendpath = await StorageFolder.GetFolderFromPathAsync(racetruckpath);

                await racetruckFile.CopyAsync(racetruckendpath);

                Process.Start("explorer.exe", racetruckpath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }

            if (MainWindow.endtext == "citybus")
            {
                Uri citybusUri = new($"ms-appx:///Assets/uv's/citybus_skin_SKINNAME.png");
                StorageFile citybusFile = await StorageFile.GetFileFromApplicationUriAsync(citybusUri);

                string citybuspath = MainWindow.pppth;
                StorageFolder citybusendpath = await StorageFolder.GetFolderFromPathAsync(citybuspath);

                await citybusFile.CopyAsync(citybusendpath);

                Process.Start("explorer.exe", citybuspath);

                downloadtextrun.Text = "UV карта загружена,";
                downloadtextspan.Text = "отредактируйте её и нажмите далее.";
            }
        }

        private void dalee2btn_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(uploadingUVPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            downloadbutton.IsEnabled = false;
        }
    }
}
