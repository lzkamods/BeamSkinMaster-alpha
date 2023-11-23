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
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.ApplicationModel.Core;
using WinRT.Interop;
using BeamSkinMaster.classes;
using Microsoft.UI.Xaml.Media.Animation;
using System.Security.Cryptography.X509Certificates;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class uploadingUVPage : Page
    {
        public uploadingUVPage()
        {
            this.InitializeComponent();
        }

        public static Button button {  get; set; }
        public static string image;

        public async void PickAFileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create a file picker
                var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

                // Retrieve the window handle (HWND) of the current WinUI 3 window.
                IntPtr hWnd = WindowNative.GetWindowHandle(App.Window);


                // Initialize the file picker with the window handle (HWND).
                WinRT.Interop.InitializeWithWindow.Initialize(openPicker, hWnd);

                // Set options for your file picker
                openPicker.ViewMode = PickerViewMode.Thumbnail;
                openPicker.FileTypeFilter.Add(".dds");

                // Open the picker for the user to pick a file
                var file = await openPicker.PickSingleFileAsync();
                if (file != null)
                {
                    StorageFile imagefile = await StorageFile.GetFileFromPathAsync(file.Path);

                    string imagepath = MainPage.pppth;
                    StorageFolder imageendpath = await StorageFolder.GetFolderFromPathAsync(imagepath);


                    await imagefile.CopyAsync(imageendpath);
                    image = System.IO.Path.Combine(imageendpath.Path, file.Name);
                }
                else
                {
                    ContentDialog cancelled = new ContentDialog
                    {
                        Title = UpldCntDlgTitle.Text,
                        Content = UpldCntDngCnt.Text,
                        CloseButtonText = "OK",
                    };
                    cancelled.XamlRoot = PickAFileButton.XamlRoot;

                    ContentDialogResult result = await cancelled.ShowAsync();
                }

                button = PickAFileButton;
            }
            catch (Exception ex)
            {
                ContentDialog autoerror = new ContentDialog
                {
                    Title = UpldErrDlgTitle.Text,
                    Content = UpldErrDngCnt.Text,
                    CloseButtonText = "OK",
                };
                autoerror.XamlRoot = PickAFileButton.XamlRoot;

                ContentDialogResult result = await autoerror.ShowAsync();
            }

        }

        private async void Uploadingdalee_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(image))
            {
                ContentFrame.Navigate(typeof(ChoosingNamePage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
                PickAFileButton.IsEnabled = false;
                Uploadingdalee.IsEnabled = false;
                MainPage.progressBar.Value = 74;
            }
            else
            {
                ContentDialog imgexterr = new ContentDialog
                {
                    Title = UpldErrDlgTitle.Text,
                    Content= UpldErrDngCnt.Text,
                    CloseButtonText = "OK",
                };
                imgexterr.XamlRoot = PickAFileButton.XamlRoot;
                ContentDialogResult result = await imgexterr.ShowAsync();
            }
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(DownloadingUVPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            MainPage.progressBar.Value = 37;
        }
    }
}
