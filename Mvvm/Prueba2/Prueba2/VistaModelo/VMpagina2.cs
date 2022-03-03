using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prueba2.VistaModelo
{
    public  class VMpagina2:BaseViewModel
    {
        #region variables
        string _txt;

        #endregion
        #region constructor
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
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
        public async Task Volver()
        {
            await Navigation.PopAsync();

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region Comandos
        public ICommand VolverAsyncommand => new Command(async () => await Volver());
        public ICommand ProcesoSimplecomand => new Command(ProcesoSimple);

        public INavigation Navigation { get; }
        #endregion
    }
}
