using BookingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.ViewModels
{
    public class OpeningPageViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseService _context;

        public Command BookRoomCommand { get; set; }
        public Command ManageBooksCommand { get; set; }

        public OpeningPageViewModel(DatabaseService context)
        {
            _context = context;

            BookRoomCommand = new Command(OnBookRoom);
            ManageBooksCommand = new Command(OnManageBooks);
        }

        private void OnManageBooks(object obj)
        {
            
        }

        private void OnBookRoom(object obj)
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

    
