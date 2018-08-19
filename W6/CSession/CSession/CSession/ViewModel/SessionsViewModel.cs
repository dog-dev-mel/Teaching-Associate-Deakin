using ConferenceSessions.Data;
using ConferenceSessions.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceSessions.ViewModel
{
    public class SessionsViewModel
    {

        SessionsManager sessionsManger = new SessionsManager();

        public event PropertyChangedEventHandler PropertyChanged;
        ObservableCollection<Session> _SessionsList;
        public ObservableCollection<Session> SessionsList
        {

            get { return _SessionsList; }
            
            set
            {
                _SessionsList = value;

                //if (PropertyChanged != null)
                //{
                //    PropertyChanged(this, new PropertyChangedEventArgs("SessionsList"));
                //}

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SessionsList"));
            }          
        }


        public SessionsViewModel()
        {
            FetchDataAsync();
        }

        public async Task FetchDataAsync()
        {
            var list = await sessionsManger.FetchSessionsAsync();
            _SessionsList = new ObservableCollection<Session>(list);
        }
    }
}
