using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /*var pagina = new NavigationPage(
            new XamarinForms.Paginas.PaginasDeNavegacao.Conteudo01()
            )
            // MainPage = new XamarinForms.Paginas.Modal.Conteudo01();

            var pagina = new CarouselPage(); 
            //Adiciona paginas ao carrosel
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo02());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrosel.Conteudo03());
            pagina.CurrentPage = pagina.Children[1]; //Define a pagina inicial do carrosel
            //MainPage = new XamarinForms.Paginas.PaginaDeCarrosel.Carrosel();

            //Aba
            // MainPage = new XamarinForms.Paginas.PaginadeAbas.Abas();


            
            //Menu
            var pagina = new MasterDetailPage();
            pagina.Master = ;

            //Conteudo
            pagina.Detail = ;
            
             
             */


            MainPage = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
                           

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
