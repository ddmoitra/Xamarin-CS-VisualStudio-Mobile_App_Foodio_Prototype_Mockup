using Foodio.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Foodio.Views
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