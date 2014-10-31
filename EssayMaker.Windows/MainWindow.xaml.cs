using System.Linq;
using MahApps.Metro;
using System.Windows;

namespace EssayMaker.Windows
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();

            ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.Accents.First(x => x.Name == "Emerald"), ThemeManager.AppThemes.First());
            ThemeManager.ChangeAppTheme(Application.Current, ThemeManager.AppThemes.First().Name);
        }
    }
}
