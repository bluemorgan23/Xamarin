using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqlLiteMobile
{
    public partial class App : Application
    {
        public App(iProductsRepository productsRepository)
        {
            InitializeComponent();

            MainPage = new ProductsPage()
            {
                BindingContext = new ProductViewModel(productsRepository)

            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
