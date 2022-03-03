using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.ViewModel
{
    public class VMpatron : BaseViewModel
    {
        #region variables
        string _txt;

        #endregion
        #region constructor
        public VMpatron(INavigation navigation)
        {
            Navegation = navigation;
        }
        #endregion
        #region Objetos
        public string Texto
        {
            get { return _txt; }
            set { SetValue(ref _txt, value); }
        }
        #endregion
        #region Procesos
        public async Task ProcesoAsncrono()
        {
            //proceso 1 
            //proceso 2

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region Comandos
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsncrono());
        public ICommand ProcesoSimplecomand => new Command(ProcesoSimple);

        public INavigation Navegation { get; }
        #endregion
    }
}
