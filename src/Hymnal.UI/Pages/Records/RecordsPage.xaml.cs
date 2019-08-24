using Hymnal.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace Hymnal.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true, NoHistory = false, Title = "Historial")]
    public partial class RecordsPage : MvxContentPage<RecordsViewModel>
    {
        public RecordsPage()
        {
            InitializeComponent();
        }
    }
}
