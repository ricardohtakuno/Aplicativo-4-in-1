using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo_4_in_1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastrarLivro : ContentPage
	{
        public int ISBN { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Titulo { get; set; }
		public CadastrarLivro ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
	}
}