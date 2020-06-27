using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GibDD.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(Profile editableProfile)
        {
            BindingContext = editableProfile;
            InitializeComponent();
            RegionPicker.ItemsSource = RegDivData.Regions;
            EvsRegionPicker.ItemsSource = RegDivData.Regions;

            RegionPicker.SelectedIndex = editableProfile.RegionId;
            DivisionPicker.SelectedIndex = editableProfile.DivisionId;
            EvsRegionPicker.SelectedIndex = editableProfile.EvsRegionId;
        }
        public ProfilePage()
        {
            InitializeComponent();
            RegionPicker.ItemsSource = RegDivData.Regions;
            RegionPicker.SelectedIndex = 0;
            EvsRegionPicker.ItemsSource = RegDivData.Regions;
            EvsRegionPicker.SelectedIndex = 0;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void SaveProfile(object sender, EventArgs e)
        {
            var profile = (Profile)BindingContext;
            profile.RegionId = RegionPicker.SelectedIndex;
            profile.Region = RegionPicker.ItemsSource[RegionPicker.SelectedIndex].ToString();

            profile.DivisionId = DivisionPicker.SelectedIndex;
            profile.Division = DivisionPicker.ItemsSource[DivisionPicker.SelectedIndex].ToString();

            profile.EvsRegionId = EvsRegionPicker.SelectedIndex;
            profile.EvsRegion = EvsRegionPicker.ItemsSource[EvsRegionPicker.SelectedIndex].ToString();

            if (!String.IsNullOrEmpty(profile.Name) &&
                !String.IsNullOrEmpty(profile.Surname) &&
                !String.IsNullOrEmpty(profile.Patronymic) &&
                !String.IsNullOrEmpty(profile.Email) &&
                !String.IsNullOrEmpty(profile.Phone) &&
                !String.IsNullOrEmpty(profile.Region) &&
                !String.IsNullOrEmpty(profile.Division) &&
                !String.IsNullOrEmpty(profile.EvsRegion))
            {
                App.Database.SaveItem("Profiles", profile);
                this.Navigation.PopAsync();
            } else
            {
                foreach (Entry entr in new Entry[] { NameEntry, SurnameEntry, PatronymicEntry, EmailEntry, PhoneEntry })
                    if (String.IsNullOrEmpty(entr.Text))
                    {
                        entr.BackgroundColor = Color.FromRgba(255, 0, 0, 0.2);
                        entr.Placeholder = "Поле не может быть пустым!";
                    }
            }
        }
        private void DeleteProfile(object sender, EventArgs e)
        {
            var profile = (Profile)BindingContext;
            App.Database.DeleteItem(profile.Id, "Profiles");
            this.Navigation.PopAsync();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        private void EntryChanged(object sender, TextChangedEventArgs e) {
            Entry entr = (Entry)sender;
            entr.BackgroundColor = Color.FromHex("#C561D3");
            if (String.IsNullOrEmpty(entr.Text))
            {
                entr.BackgroundColor = Color.FromRgba(255, 0, 0, 0.2);
                entr.Placeholder = "Поле не может быть пустым!";
            }
        }

        private void SelectRegion(object sender, EventArgs e)
        {
            DivisionPicker.ItemsSource = RegDivData.Regions[RegionPicker.SelectedIndex].Subdivisions;
            DivisionPicker.SelectedIndex = 0;
        }
    }
}