using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestXamlMaterialDesign
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // force load material desgn dll
            var card = new MaterialDesignThemes.Wpf.Card();
            var hue = new MaterialDesignColors.Hue(
                "Dummy",
                System.Windows.Media.Colors.Black,
                System.Windows.Media.Colors.White);
        }
    }
}