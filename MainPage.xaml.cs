using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class MainPage : ContentPage
    {


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            string nomeAquivo = Path.GetRandomFileName();
            label_inicial.Text = nomeAquivo + ".txt";
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorContexto;
            editor_valor.Text = App.PastaDiretorio;
        }
    }
}
