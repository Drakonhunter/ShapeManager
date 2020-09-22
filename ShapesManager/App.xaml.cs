using Services;
using System.Windows;
using Visuals;

namespace ShapesManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            
            var shapeSaver = new ShapeSaver();
            var mainWindowVM = new MainWindowVM(shapeSaver);
            var shapeVM = new ShapeVM();
            shapeVM.Color = "blue";
            shapeVM.Name = "Circle(ish)";
            mainWindowVM.SelectedShape = shapeVM;
            mainWindow.DataContext = mainWindowVM;
            mainWindow.Show();
        }
    }
}
