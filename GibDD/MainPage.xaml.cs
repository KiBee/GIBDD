using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;
using GibDD.Pages;

namespace GibDD
{
    public class MainModel
    {
        public Profile selectedProfile { get; set; }
        public Appeal selectedAppeal { get; set; }
        public ObservableCollection<Photo> selectedPhotos { get; set; }
    }

    public class SelectProfile : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public INavigation Navigation;
        public MainModel _MainModel;

        public SelectProfile(INavigation nav, MainModel mainModel)
        {
            _MainModel = mainModel;
            Navigation = nav;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            _MainModel.selectedProfile = (Profile) parameter;
            Pages.AppealPage profilePage = new Pages.AppealPage(_MainModel);
            await Navigation.PushAsync(profilePage);
        }
    }

    public class EditProfile : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public INavigation Navigation;

        public EditProfile(INavigation nav)
        {
            Navigation = nav;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            Pages.ProfilePage profilePage = new Pages.ProfilePage((Profile) parameter);
            await Navigation.PushAsync(profilePage);
        }
    }

    [Table("Profiles")]
    public class Profile
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public string Citizen { get; set; }
        
        
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        
        
        
        
        public string Email { get; set; }
        public string Phone { get; set; }
        
        
        
        public string Region { get; set; }
        public int RegionId { get; set; }
        public string Division { get; set; }
        public int DivisionId { get; set; }
        public string EvsRegion { get; set; }
        public int EvsRegionId { get; set; }
    }

    [Table("Appeals")]
    public class Appeal
    {
        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public string Text { get; set; }
    }

    public class Repository
    {
        SQLiteConnection database;

        public Repository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Profile>();
            database.CreateTable<Appeal>();
        }

        public IEnumerable<object> GetItems(string _Type)
        {
            if (_Type == "Profiles")
                return database.Table<Profile>().ToList();
            else if (_Type == "Appeals")
                return database.Table<Appeal>().ToList();
            else return database.Table<Appeal>().ToList();
        }

        public object GetItem(int id, string _Type)
        {
            if (_Type == "Profiles")
                return database.Get<Profile>(id);
            else if (_Type == "Appeals")
                return database.Get<Appeal>(id);
            else return database.Get<Appeal>(id);
        }

        public int DeleteItem(int id, string _Type)
        {
            if (_Type == "Profiles")
                return database.Delete<Profile>(id);
            else if (_Type == "Appeals")
                return database.Delete<Appeal>(id);
            else return database.Delete<Appeal>(id);
        }

        public int SaveItem(string _Type, object item)
        {
            if (_Type == "Profiles")
            {
                Profile _item = (Profile) item;
                if (_item.Id != 0)
                {
                    database.Update(_item);
                    return _item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
            else if (_Type == "Appeals")
            {
                Appeal _item = (Appeal) item;
                if (_item.Id != 0)
                {
                    database.Update(_item);
                    return _item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
            else
            {
                Appeal _item = (Appeal) item;
                if (_item.Id != 0)
                {
                    database.Update(_item);
                    return _item.Id;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public IEnumerable<object> GetItemsByQuery(string Query)
        {
            return database.Query<object>(Query).ToList();
        }
    }

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public SelectProfile SelectProfile { get; private set; }
        public EditProfile EditProfile { get; private set; }
        public MainModel _MainModel { get; set; }

        public MainPage()
        {
            if (_MainModel == null)
                _MainModel = new MainModel();
            BindingContext = this;
            SelectProfile = new SelectProfile(Navigation, _MainModel);
            EditProfile = new EditProfile(Navigation);
            var items = App.Database.GetItems("Divisions");

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            profilesList.ItemsSource = App.Database.GetItems("Profiles");
            base.OnAppearing();
        }

        private async void CreateProfile(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            Pages.ProfilePage profilePage = new Pages.ProfilePage();
            profilePage.BindingContext = profile;
            await Navigation.PushAsync(profilePage);
        }

        private void profilesList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView) sender).SelectedItem = null;
        }
    }
}