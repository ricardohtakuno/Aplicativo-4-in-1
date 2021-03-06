﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo_4_in_1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgendarConsulta : ContentPage
	{
        public string Nome { get; set; }
        public DateTime DataAgendamento { get; set; }
        public TimeSpan HoraAgendamento { get; set; }
        
		public AgendarConsulta ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var data = dtpData.Date;
            var hora = tmpTime.Time;
            var area = pckArea.Items[pckArea.SelectedIndex];

            DisplayAlert("Informações", string.Format("Nome: {0} \n\nData: {1} \n\nHora: {2} \n\nÁrea: {3}", nome, data, hora, area), "ok");
        }
	}
}