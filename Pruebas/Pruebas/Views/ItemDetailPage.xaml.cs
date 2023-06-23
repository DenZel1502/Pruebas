using Pruebas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pruebas.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}