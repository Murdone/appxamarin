using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.ViewModel
{
    public class VMPagina1:BaseViewModel
    {
        #region variables
        string _N1, _N2, _Res;

        #endregion
        #region constructor
        public VMPagina1(INavigation navigation)
        {
            Navegation = navigation;
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
        public string Res
        {
            get { return _Res; }
            set { SetValue(ref _Res, value); }
        }
        #endregion
        #region Procesos
        //public async Task ProcesoAsync()
        //{
      
        //}
        public void Sumar()
        {
            double n1 = 0, n2 = 0, r;
            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = n1 + n2;
            _Res = r.ToString();
        }
        #endregion
        #region Comandos
        //public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsync());
        public ICommand Sumarcomand => new Command(Sumar);

        public INavigation Navegation { get; }
        #endregion
    }
}
