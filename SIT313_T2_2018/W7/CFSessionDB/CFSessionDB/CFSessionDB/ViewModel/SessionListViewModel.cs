using CFSessionDB.Data;
using CFSessionDB.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CFSessionDB.ViewModel
{
    public class SessionListViewModel : INotifyPropertyChanged
    {

        Database _database = new Database();

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Session> _sessionslist;
        public ObservableCollection<Session> SessionsList
        {
            get { return _sessionslist; }
            set
            {
                _sessionslist = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SessionsList"));
                }
            }
        }

        public async Task FetchDataAsync()
        {
            var list = await _database.GetAllSessionAsync();
            SessionsList = new ObservableCollection<Session>(list);
        }

        public SessionListViewModel()
        {
            FetchDataAsync();
        }
    }

}
