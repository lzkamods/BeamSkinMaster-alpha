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
using BeamSkinMaster.classes;
using Windows.Storage.Pickers;
using System.Threading.Tasks;
using Microsoft.UI.Composition.SystemBackdrops;
using Windows.UI.ViewManagement;
using BeamSkinMaster.pages;
using Microsoft.UI.Xaml.Media.Imaging;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public AppWindow m_AppWindow;


        public MainWindow()
        {
            this.InitializeComponent();

            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);      
            appWindow.Resize(new Windows.Graphics.SizeInt32 { Width = 1282, Height = 722 });

            Directory.CreateDirectory(pathes.pth);

        }
    }
}
