using System;
using System.Collections;
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
        //List<Arquivo> lista_arquivo = new List<Arquivo>();
        ArrayList lista = new ArrayList();

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //Arquivo arquivo = new Arquivo();

            //arquivo.arquivos = Path.GetRandomFileName() + ".txt";
            //label_inicial.Text =  arquivo.arquivos;
            //lista_arquivo.Add(arquivo);

            string nome = Path.GetRandomFileName() + ".txt";
            string nomeArquivo = Path.Combine(App.PastaDiretorio, $"{nome}");
            File.Create(nomeArquivo);

            label_inicial.Text = "Adicionando...";
            lista.Add(nomeArquivo);

        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageListaArquivo());
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            //string conteudoEditor = editor_valor.Text;
            //var arrayConteudo = conteudoEditor.Split('-');
            //label_inicial.Text = arrayConteudo[arrayConteudo.Count() - 1];
        }

        public MainPage()
        {
            InitializeComponent();
            label_inicial.Text = App.ValorContexto;

        }



    }
}