using MovieApp_MateoPillajo.ViewModels;
using MovieApp_MateoPillajo.Servicios;

namespace MovieApp_MateoPillajo;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        InitializeComponent();

        var rutaBD = Path.Combine(FileSystem.AppDataDirectory, "mateopillajo.db3");
        var baseDeDatosServicio = new BaseDeDatosServicio(rutaBD);

        BindingContext = new PeliculasViewModel(baseDeDatosServicio);
    }
}