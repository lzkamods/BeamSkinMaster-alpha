using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BeamSkinMaster.classes
{
    public class LocalizatoinViewViewModel : ObservableObject
    {
        private string? _topTitle;
        private readonly IThemeSelectorService _themeSelectorService;

        public string? TopTitle
        {
            get => _topTitle;
            set => SetProperty(ref _topTitle, value);
        }

        public ICommand SetThemeCommnad { get; }

        public LocalizatoinViewViewModel(IThemeSelectorService themeSelectorService)
        {
            SetThemeCommnad = new RelayCommand<string>((themeName) => UpdateTheme(themeName));
            _themeSelectorService = themeSelectorService;
        }

        private void UpdateTheme(string themeName)
        {
            if (Enum.TryParse(themeName, out ElementTheme theme) is true)
            {
                _themeSelectorService.SetTheme(theme);
            }
        }
    }
}
