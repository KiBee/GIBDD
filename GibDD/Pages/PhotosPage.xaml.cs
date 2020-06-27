using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GibDD.Pages
{
    public struct Photo
    {
        public ImageSource Image { get; set; }
    }

    public class DeletePhoto : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public readonly MainModel _MainModel;
        public readonly Button _ContinueButton;

        public DeletePhoto(MainModel mainModel, Button ContinueButton)
        {
            _MainModel = mainModel;
            _ContinueButton = ContinueButton;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _MainModel.selectedPhotos.Remove((Photo)parameter);
            if (!_MainModel.selectedPhotos.Any())
                _ContinueButton.IsEnabled = false;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotosPage : ContentPage
    {
        public MainModel _MainModel { get; set; }
        public DeletePhoto DeletePhoto { get; set;}

        public PhotosPage(MainModel mainModel)
        {
            _MainModel = mainModel;

            if (_MainModel.selectedPhotos == null)
                _MainModel.selectedPhotos = new ObservableCollection<Photo>() { };

            InitializeComponent();

            BindingContext = this;

            if (_MainModel.selectedPhotos != null)
            {
                DeletePhoto = new DeletePhoto(_MainModel, ContinueButton);
                ContinueButton.IsEnabled = true;
            }

            takePhoto.Clicked += async (sender, args) =>
            {

               

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Photos",
                    SaveToAlbum = true,
                    PhotoSize = PhotoSize.Full,
                    DefaultCamera = CameraDevice.Front
                });

                if (file == null)
                    return;

                if (_MainModel.selectedPhotos == null)
                    _MainModel.selectedPhotos = new ObservableCollection<Photo>() { };

                _MainModel.selectedPhotos.Add(new Photo
                {
                    Image = ImageSource.FromStream(() =>
                    {
                        var stream = file.GetStream();
                        return stream;
                    }),
                });
                ContinueButton.IsEnabled = true;

                DeletePhoto = new DeletePhoto(_MainModel, ContinueButton);
            };

            pickPhoto.Clicked += async (sender, args) =>
            {
               
                var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                {
                    PhotoSize = PhotoSize.Full,
                });


                if (file == null)
                    return;

                if (_MainModel.selectedPhotos == null)
                    _MainModel.selectedPhotos = new ObservableCollection<Photo>() { };

                _MainModel.selectedPhotos.Add(new Photo
                {
                    Image = ImageSource.FromStream(() =>
                    {
                        var stream = file.GetStream();
                        return stream;
                    }),
                });
                ContinueButton.IsEnabled = true;
                DeletePhoto = new DeletePhoto(_MainModel, ContinueButton);
            };
        }

        

        async private void ContinueClicked(object sender, EventArgs e)
        {
            var finalPage = new Pages.FinalPage(_MainModel);
            await Navigation.PushAsync(finalPage);
        }
        
        
        async void OpenFullPhoto(object sender, ItemTappedEventArgs e)
        {
            Pages.FullImagePage fullImagePage = new Pages.FullImagePage((Photo)e.Item);
            await Navigation.PushAsync(fullImagePage);
            ((ListView)sender).SelectedItem = null;
        }
    }
}
