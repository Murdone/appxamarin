using Prueba2.Vistas;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Prueba2.VistaModelo
{
    public class VMPagina1 : BaseViewModel
    {
        #region variables
        string _N1, _N2, _R;

        #endregion
        #region constructor
        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
            //Estaba como Navegation esto hereda de la baseviewmodel mira
        }
        #endregion
        #region Objetos
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion
        #region Procesos
        public async Task Navegacion()
        {
            await Navigation.PushAsync(new Pagina2());
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = n1 + n2;
            R = r.ToString();
        }
        #endregion
        #region Comandos
        public ICommand NavegacionAsynccommand => new Command(async () => await Navegacion());
        public ICommand Sumarcomand => new Command(Sumar);

      //  public INavigation Navegation { get; } // te equivocaste en la i es NAvigation
        #endregion
    }
}
