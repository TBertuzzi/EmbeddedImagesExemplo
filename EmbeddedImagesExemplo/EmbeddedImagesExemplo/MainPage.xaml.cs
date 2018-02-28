using EmbeddedImagesExemplo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmbeddedImagesExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.BindingContext = new MainViewModel();
            //var Imagem = ImageSource.FromResource("EmbeddedImagesExemplo.Resources.Polly.jpg");
        }
	}
}
