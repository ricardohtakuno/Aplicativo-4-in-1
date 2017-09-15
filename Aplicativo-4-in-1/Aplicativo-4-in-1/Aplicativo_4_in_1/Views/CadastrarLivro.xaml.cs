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
            var ISBN = txtISBN.Text;
            var data = dtpData.Date;
            var Titulo = txtTitulo.Text;
            var categoria = pckCategoria.Items[pckCategoria.SelectedIndex];

            DisplayAlert("Informações", string.Format("ISBN: {0} \n\nData: {1} \n\nTitulo: {2} \n\nCategoria: {3}", ISBN, data, Titulo, categoria), "ok");
        }
	}
}