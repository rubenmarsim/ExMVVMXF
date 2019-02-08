using exMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exMVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UCMainView : ContentPage
	{
		public UCMainView ()
		{
			InitializeComponent ();
			BindingContext = new MainViewModel();
		}
	}
}