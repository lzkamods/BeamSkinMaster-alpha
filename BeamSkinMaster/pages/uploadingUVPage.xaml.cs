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

        private async void PickAFileButton_Click(object sender, RoutedEventArgs e)
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

                string imagepath = MainWindow.pppth;
                StorageFolder imageendpath = await StorageFolder.GetFolderFromPathAsync(imagepath);


                await imagefile.CopyAsync(imageendpath);

            }
            else
            {
                ContentDialog cancelled = new ContentDialog
                {
                    Title = "Ошибка выбора изображения",
                    Content = "Невозможно Скопировть изображение, так как оно пустое. Пожалуйста, выберите изображение.",
                    CloseButtonText = "OK",
                };
                cancelled.XamlRoot = PickAFileButton.XamlRoot;

                ContentDialogResult result = await cancelled.ShowAsync();
            }
        }

        private void Uploadingdalee_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ChoosingNamePage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            PickAFileButton.IsEnabled = false;
            Uploadingdalee.IsEnabled = false;
        }
    }
}
