using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tienda.Modelo;
using Tienda.VistaModelo;
using Xamarin.Forms;

namespace Tienda.VistaModelo
{
    class VMDetalle:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public MProductos ParametroRecibe {  get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMDetalle(INavigation navigation, MProductos parametrosTrae)
        {
            Navigation = navigation;
            ParametroRecibe = parametrosTrae;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async void Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(Volver);
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
