using HelloWorld.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HelloWorld.Views
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