using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace ArquivoApp
{
    public partial class PageListaArquivo : ContentPage
    {
        ArrayList listadearquivos = new ArrayList();


        public PageListaArquivo()
        {
            InitializeComponent();
            //listView_arquivo.ItemsSource = lista;
            NavigationPage.SetHasBackButton(this, false);
        }

        void voltar(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            var meusarquivos = new List<Arquivo>();
            var arquivos = Directory.EnumerateFiles(App.PastaDiretorio,"*.txt");
            foreach(var nomedoarquivo in arquivos)
            {
                //int indice = nomedoarquivo.LastIndexOf('/');
                //listadearquivos.Add(nomedoarquivo.Substring(indice + 1));
                //meusarquivos.Add(new Arquivo {Conteudo = "Teste..."});
                //File.Delete(nomedoarquivo);
                meusarquivos.Add(new Arquivo
                {
                   Conteudo = File.ReadAllText(nomedoarquivo),
                    DtCriacao = File.GetCreationTime(nomedoarquivo).ToString()
                });
            }

            listView_listaarquivo.ItemsSource = meusarquivos;
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var valor = sender;
            //var eh = e;
            //await DisplayAlert("Titulo", e.SelectedItem.ToString(), "Ok");
            var resposta = await DisplayAlert("Titulo", "Desejar Excluir", "Sim", "Nao");

            if(resposta == true){
                File.Delete(Path.Combine(App.PastaDiretorio, $"{e.SelectedItem.ToString()}"));
                await Navigation.PushAsync(new PageListaArquivo());
            }




        }


    }
}
