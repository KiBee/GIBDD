using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GibDD.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FullImagePage : ContentPage
    {
        public FullImagePage(Photo image)
        {
            BindingContext = image.Image;
            InitializeComponent();
        }
    }
}