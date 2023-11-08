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
using Windows.System;
using Windows.Foundation.Collections;
using Microsoft.UI;
using CommunityToolkit.Mvvm.DependencyInjection;
using System.Reflection;
using BeamSkinMaster.classes;
using BeamSkinMaster.Models;
using Microsoft.Windows.ApplicationModel.Resources;
using System.Collections.ObjectModel;
using Windows.Globalization;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster.pages.Views
{

    public class LanguageItem
    {
        public LanguageItem(string languageTag, string displayName)
        {
            LanguageTag = languageTag;
            DisplayName = displayName;
        }

        public string LanguageTag { get; }

        public string DisplayName { get; }
    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LocalizationViev : Page
    {
        private ResourceManager resourceManager = new();

        private ResourceLoader resourceLoader = new();

        public LocalizatoinViewViewModel ViewModel { get; }

        public LocalizationViev()
        {
            this.InitializeComponent();
            ViewModel = Ioc.Default.GetRequiredService<LocalizatoinViewViewModel>();

            LanguageItems.Add(new LanguageItem("en-US", this.resourceLoader.GetString("en-US")));
            LanguageItems.Add(new LanguageItem("ru-RU", this.resourceLoader.GetString("ru-RU")));
        }

        public ObservableCollection<LanguageItem> LanguageItems { get; } = new();

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is not ComboBox languageTagComboBox)
            {
                return;
            }

            if (LanguageItems
                .Where(x => x.LanguageTag == ApplicationLanguages.PrimaryLanguageOverride)
                .FirstOrDefault() is LanguageItem currentLanguageItem)
            {

                languageTagComboBox.SelectedValue = currentLanguageItem;
            }
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is not ComboBox languageTagComboBox ||
            languageTagComboBox.SelectedValue is not LanguageItem selectedLanguageItem)
            {
                return;
            }

            ApplicationLanguages.PrimaryLanguageOverride = selectedLanguageItem.LanguageTag;

            ResourceContext resourceContext = this.resourceManager.CreateResourceContext();
            resourceContext.QualifierValues["Language"] = selectedLanguageItem.LanguageTag;
        }
    }
}
