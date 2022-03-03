using Prueba2.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba2.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
            BindingContext = new VMpagina2(Navigation);
        }
    }
}