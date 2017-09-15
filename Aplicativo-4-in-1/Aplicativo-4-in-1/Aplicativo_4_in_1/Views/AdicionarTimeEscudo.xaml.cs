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
	public partial class AdicionarTimeEscudo : ContentPage
	{
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Jogadores { get; set; }

		public AdicionarTimeEscudo ()
		{
			InitializeComponent ();
		}
	}
}