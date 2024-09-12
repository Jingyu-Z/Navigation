using BookingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ViewModels
{
    public class BookingPageViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseService _context;

        public Command SelectRoomCommand { get; set; }
        public BookingPageViewModel(DatabaseService context)
        {
            _context = context;

            SelectRoomCommand = new Command(OnSelect);
        }

        private void OnSelect(object obj)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
