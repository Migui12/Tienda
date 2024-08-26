using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.VistaModelo;
using Tienda.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tienda.Views.Detalle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VDProducto : ContentPage
	{
		public VDProducto (MProductos parametros)
		{
			InitializeComponent ();
			BindingContext = new VMDetalle(Navigation, parametros);
		}
	}
}