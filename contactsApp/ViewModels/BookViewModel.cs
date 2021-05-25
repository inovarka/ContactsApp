using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using contactsApp.Services;
using contactsApp.Utility;

namespace contactsApp.ViewModels
{
    public class BookViewModel : ObservableObject
    {
        private IContactDataService _service;

        private ContactsViewModel _contactsVM;
        public ContactsViewModel ContactsVM
        {
            get { return _contactsVM; }
            set { OnPropertyChanged(ref _contactsVM, value); }
        }

        public ICommand LoadFavoritesCommand { get; private set; }
        public ICommand LoadContactsCommand { get; private set; }

        public BookViewModel(IContactDataService service)
        {
            ContactsVM = new ContactsViewModel();

            _service = service;

            LoadFavoritesCommand = new RelayCommand(LoadFavorites);
            LoadContactsCommand = new RelayCommand(LoadContacts);
        }

        private void LoadContacts()
        {
            ContactsVM.LoadContacts(_service.GetContacts());
        }

        private void LoadFavorites()
        {
            var favorites = _service.GetContacts().Where(c => c.IsFavorite);
            ContactsVM.LoadContacts(favorites);
        }
    }
}
