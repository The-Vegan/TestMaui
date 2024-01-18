using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaui.Models
{
    public class Pic : INotifyPropertyChanged
    {
        private string source;
        public string Source 
        {
            get => source;
            set
            {
                source = value;
                OnPropertyChanged(nameof(Source));
            }
        }

        private string category;
        public string Category
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Pic()
        {
            this.Source = "dotnet_bot.png";
            this.Category = "default";
        }
        /*
        public Pic(string source, string category)
        {
            this.Source = source;
            this.Category = category;
        }
        */
    }
}
