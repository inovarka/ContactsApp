using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using contactsApp.Utility;

namespace contactsApp.ViewModels
{
    public class BookViewModel : ObservableObject
    {
        private ContactsViewModel _contactsVM;
        public ContactsViewModel ContactsVM
        {
            get { return _contactsVM; }
            set { OnPropertyChanged(ref _contactsVM, value); }
        }

        public ICommand LoadFavoritesCommand { get; private set; }
        public ICommand LoadContactsCommand { get; private set; }

        public BookViewModel()
        {
            ContactsVM = new ContactsViewModel();

            LoadFavoritesCommand = new RelayCommand(LoadFavorites);
            LoadContactsCommand = new RelayCommand(LoadContacts);
        }

        private void LoadContacts()
        {

        }

        private void LoadFavorites()
        {

        }
    }
}
