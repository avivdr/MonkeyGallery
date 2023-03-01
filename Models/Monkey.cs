using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyGallery.Models
{
    internal class Monkey : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }      

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void Copy(Monkey other)
        {
            Name = other.Name;
            Location = other.Location;
            Details = other.Details;
            Population = other.Population;
            Image = other.Image;
            OnPropertyChanged("Name");
            OnPropertyChanged("Location");
            OnPropertyChanged("Details");
            OnPropertyChanged("Population");
            OnPropertyChanged("Image");
        }

        public Monkey() { }
        public Monkey(Monkey other)
        {
            Name = other.Name;
            Location = other.Location;
            Details = other.Details;
            Population = other.Population;
            Image = other.Image;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
