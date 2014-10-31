using MahApps.Metro;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace EssayMaker.Windows
{
    /// <summary>
    /// Interaction logic for SidePanel_Settings.xaml
    /// </summary>
    public partial class SidePanel_Settings : UserControl
    {
        public List<AccentColorMenuData> AccentColors { get; set; }
        public List<AppThemeMenuData> AppThemes { get; set; }

        public SidePanel_Settings()
        {
            // create accent color menu items
            this.AccentColors = ThemeManager.Accents
                .Select(a => new AccentColorMenuData() { Name = a.Name, ColorBrush = a.Resources["AccentColorBrush"] as Brush })
                .ToList();

            // create metro theme color menu items
            this.AppThemes = ThemeManager.AppThemes
                .Select(a => new AppThemeMenuData() { Name = a.Name, BorderColorBrush = a.Resources["BlackColorBrush"] as Brush, ColorBrush = a.Resources["WhiteColorBrush"] as Brush })
                .ToList();

            InitializeComponent();
        }
    }
}
