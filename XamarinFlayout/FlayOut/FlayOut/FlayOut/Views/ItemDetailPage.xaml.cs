using FlayOut.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FlayOut.Views
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