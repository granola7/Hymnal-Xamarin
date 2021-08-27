using Hymnal.XF.ViewModels;
using Xamarin.Forms.Xaml;

namespace Hymnal.XF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public sealed partial class ThematicSubGroupPage : BaseContentPage<ThematicSubGroupViewModel>
    {
        public ThematicSubGroupPage()
        {
            InitializeComponent();
        }
    }
}
