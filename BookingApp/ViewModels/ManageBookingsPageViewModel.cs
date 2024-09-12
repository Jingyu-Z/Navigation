using BookingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ViewModels
{
    public class ManageBookingsPageViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseService _context;
        private Command ViewBooksCommand { get; set; }
        private Command EditProfileCommand { get; set; }
        private Command LogoutCommand { get; set; }
        private Command BackCommand { get; set; }
        public ManageBookingsPageViewModel(DatabaseService context)
        {
            _context = context;

            ViewBooksCommand = new Command(OnViewBooks);
            EditProfileCommand = new Command(OnEditProfile);
            LogoutCommand = new Command(OnLogout);
            BackCommand = new Command(OnBack);
        }

        private void OnBack(object obj)
        {
            
        }

        private void OnLogout(object obj)
        {
            
        }

        private void OnEditProfile(object obj)
        {
            
        }

        private void OnViewBooks(object obj)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
