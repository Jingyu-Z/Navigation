//using BookingApp.Services;
//using BookingApp.Views;
//using System.Diagnostics;
//using System.IO;

//namespace BookingApp
//{
//    public partial class App : Application
//    {

//        public static DatabaseService? DatabaseService { get; private set; }

//        public App()
//        {
//            InitializeComponent();

//            // Set up the path for the SQLite database
//            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bookingappdb.db3");

//            DatabaseService = new DatabaseService(dbPath);

//            CheckDatabaseContent();

//            MainPage = new AppShell();


//            public static void PrintDatabasePath()
//            {
//                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bookingappdb.db3");
//                Debug.WriteLine($"Database path: {dbPath}");
//            }

//            public void CheckDatabaseContent()
//            {
//                if (DatabaseService != null)
//                {
//                    var rooms = DatabaseService.GetAllRooms();
//                    var availableDays = DatabaseService.GetAvailableDays(1); // Adjust room ID as needed
//                    var roomSlots = DatabaseService.GetRoomSlots(1); // Adjust availableDay ID as needed

//                    Debug.WriteLine($"Rooms count: {rooms.Count}");
//                    Debug.WriteLine($"AvailableDays count: {availableDays.Count}");
//                    Debug.WriteLine($"RoomSlots count: {roomSlots.Count}");
//                }
//                else
//                {
//                    Debug.WriteLine("DatabaseService is not initialized.");
//                }
//            }
//        }
//    }
//}

using BookingApp.Services;
using BookingApp.Views;
using System.Diagnostics;
using System.IO;

namespace BookingApp
{
    public partial class App : Application
    {
        public static DatabaseService? DatabaseService { get; private set; }

        public App()
        {
            InitializeComponent();

            // Set up the path for the SQLite database
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bookingappdb.db3");

            DatabaseService = new DatabaseService(dbPath);

            CheckDatabaseContent();

            MainPage = new AppShell();
        }

        // Static method to print the database path
        public static void PrintDatabasePath()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "bookingappdb.db3");
            Debug.WriteLine($"Database path: {dbPath}");
        }

        // Method to check and log the content of the database
        public void CheckDatabaseContent()
        {
            if (DatabaseService != null)
            {
                var rooms = DatabaseService.GetAllRooms();
                var availableDays = DatabaseService.GetAvailableDays(1); // Adjust room ID as needed
                var roomSlots = DatabaseService.GetRoomSlots(1); // Adjust availableDay ID as needed

                Debug.WriteLine($"Rooms count: {rooms.Count}");
                Debug.WriteLine($"AvailableDays count: {availableDays.Count}");
                Debug.WriteLine($"RoomSlots count: {roomSlots.Count}");
            }
            else
            {
                Debug.WriteLine("DatabaseService is not initialized.");
            }
        }
    }
}
