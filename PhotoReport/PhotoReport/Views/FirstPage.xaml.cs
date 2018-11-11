using PhotoReport.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoReport.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPage
	{
        FirstPageMV firstPageMV = null;

        public FirstPage ()
		{
            firstPageMV = new FirstPageMV();
            InitializeComponent ();
            BindingContext = firstPageMV;
		}
	}
}