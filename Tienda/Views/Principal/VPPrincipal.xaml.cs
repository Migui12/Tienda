using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tienda.Views.Principal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VPPrincipal : ContentPage
	{
		public VPPrincipal ()
		{
			InitializeComponent ();
			BindingContext = new VMPrincipal(Navigation);
		}
	}
}