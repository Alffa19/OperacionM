using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OperacionM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            var ope = new Models.Operaciones
            {
                Numero1 = Convert.ToDouble(txtnumero1.Text),
                Numero2 = Convert.ToDouble(txtnumero2.Text),
                Resultado = Convert.ToDouble(txtnumero1.Text) + Convert.ToDouble(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = ope;
            await Navigation.PushModalAsync(page);
        }

        private async void btnrestar_Clicked(object sender, EventArgs e)
        {
            var ope = new Models.Operaciones
            {
                Numero1 = Convert.ToDouble(txtnumero1.Text),
                Numero2 = Convert.ToDouble(txtnumero2.Text),
                Resultado = Convert.ToDouble(txtnumero1.Text) - Convert.ToDouble(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = ope;
            await Navigation.PushModalAsync(page);
        }

        private async void btndividir_Clicked(object sender, EventArgs e)
        {
            var ope = new Models.Operaciones
            {
                Numero1 = Convert.ToDouble(txtnumero1.Text),
                Numero2 = Convert.ToDouble(txtnumero2.Text),
                Resultado = Convert.ToDouble(txtnumero1.Text) / Convert.ToDouble(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = ope;
            await Navigation.PushModalAsync(page);
        }

        private async void btnmultiplicar_Clicked(object sender, EventArgs e)
        {
            var ope = new Models.Operaciones
            {
                Numero1 = Convert.ToDouble(txtnumero1.Text),
                Numero2 = Convert.ToDouble(txtnumero2.Text),
                Resultado = Convert.ToDouble(txtnumero1.Text) * Convert.ToDouble(txtnumero2.Text)
            };
            var page = new Views.PageTwo();
            page.BindingContext = ope;
            await Navigation.PushModalAsync(page);
        }
    }
}
