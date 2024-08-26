    using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tienda.Datos;
using Tienda.Modelo;
using Tienda.VistaModelo;
using Xamarin.Forms;
using Tienda.Views.Detalle;

namespace Tienda.VistaModelo
{
    public class VMPrincipal:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<MProductos> _listarProductos;
        #endregion
        #region CONSTRUCTOR
        public VMPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            ListarProductos();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<MProductos> ListaProductos
        {
            get { return _listarProductos; }
            set { SetValue(ref _listarProductos, value); }
        }
        #endregion
        #region PROCESOS
        public void ListarProductos()
        {
            var funcion = new DProductos();
            ListaProductos = funcion.ListarProductos();
        }
        public async void SeleccionarProducto(MProductos parametros)
        {
            await Navigation.PushAsync(new VDProducto(parametros));
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand Seleccionarproducto => new Command<MProductos>(SeleccionarProducto);
        #endregion
    }
}
