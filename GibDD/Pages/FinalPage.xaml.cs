using System;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GibDD.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalPage : ContentPage
    {
        public MainModel _MainModel { get; set; }
        public FinalPage(MainModel mainModel)
        {
            _MainModel = mainModel;
            BindingContext = _MainModel;

            Title = "Итоговое обращение";

            var photosCount = _MainModel.selectedPhotos.Count();
            var rows = new RowDefinitionCollection() { };

            for (var i = 0; i < photosCount; i += 3)
                rows.Add(new RowDefinition { Height = 80 });

            Grid photoGrid = new Grid
            {
                RowDefinitions = rows,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
                

            var photosId = 0;
            for (var i = 0; i < photoGrid.RowDefinitions.Count(); i++)
                for (var j = 0; j < photoGrid.ColumnDefinitions.Count(); j++)
                {
                    var tapGestureRecognizer = new TapGestureRecognizer();
                    tapGestureRecognizer.Tapped += async (s, e) => {
                        Pages.FullImagePage fullImagePage = new Pages.FullImagePage(new Photo() { Image = ((Image)s).Source });
                        await Navigation.PushAsync(fullImagePage);
                    };

                    Image image = new Image { Source = _MainModel.selectedPhotos[photosId].Image };
                    image.GestureRecognizers.Add(tapGestureRecognizer);

                    photoGrid.Children.Add(new Frame { Content = image, BorderColor = Color.FromRgb(10, 10, 10), Padding = 1 }, j, i );
                    photosId++;
                    if (photosId == photosCount) break;
                }

            photoGrid.RowSpacing = 0;
            photoGrid.ColumnSpacing = 0;

            Button finalButton = new Button() { Text = "Отправить" };
            finalButton.Clicked += FinalButtonClicked;

            Content = new StackLayout
            {
                Children =
                {
                    new ScrollView
                    {
                        Content = new StackLayout
                        {
                            Children =
                            {
                                new Label { Text = "ФИО:", Margin = 0, Padding = 0, FontSize = 22, TextColor = Color.Black },
                                new Label { Text = "Фамилия: " + _MainModel.selectedProfile.Surname, Margin = 0, Padding = 0, FontSize = 22 },
                                new Label { Text = "Имя: " + _MainModel.selectedProfile.Name, Margin = 0, Padding = 0, FontSize = 22 },
                                new Label { Text = "Отчество: " + _MainModel.selectedProfile.Patronymic, Margin = new Thickness(0, 0, 0, 15), Padding = 0, FontSize = 22 },
                                
                                new Label { Text = "Контактная информация:", Margin = 0, Padding = 0, FontSize = 22, TextColor = Color.Black },
                                new Label { Text = "Телефон: " + _MainModel.selectedProfile.Phone, Margin = new Thickness(0, 0, 0, 10), Padding = 0, FontSize = 18 },
                                new Label { Text = "Email: " + _MainModel.selectedProfile.Email, Margin = 0, Padding = 0, FontSize = 18 },
                                
                                new Label { Text = "Регион: " + _MainModel.selectedProfile.Region, Margin = 0, Padding = 0, FontSize = 18 },
                                new Label { Text = "Отделение: " + _MainModel.selectedProfile.Division, Margin = 0, Padding = 0, FontSize = 18 },
                                new Label { Text = "Место события (регион): " + _MainModel.selectedProfile.EvsRegion, Margin = 0, Padding = 0, FontSize = 18 },
                                
                                
                                new Label { Text = "Текст обращения:", Margin = new Thickness(0, 15, 0, 0), Padding = 0, FontSize = 22, TextColor = Color.Black },
                                new Label { Text = _MainModel.selectedAppeal.Text, Margin = new Thickness(0, 5, 0, 15), Padding = 0, FontSize = 20 },
                                new Label { Text = "Прикрепленные файлы:", Margin = new Thickness(0, 15, 0, 5), Padding = 0, FontSize = 22, TextColor = Color.Black },
                                photoGrid
                            },
                            Spacing = 0
                        }
                    },
                    finalButton
                },
                Padding = 15
            };
        }

        async public void FinalButtonClicked(object sender, EventArgs e)
        {
            _MainModel = null;
            await Navigation.PopToRootAsync();
        }
    }
}