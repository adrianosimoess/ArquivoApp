using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class ConsumeContexto : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }

        public ConsumeContexto()
        {
            InitializeComponent();
            label_secundaria.Text = App.ValorContexto;
        }
    }
}
