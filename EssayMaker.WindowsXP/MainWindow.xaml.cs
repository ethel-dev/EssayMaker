using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro;

namespace EssayMaker.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
