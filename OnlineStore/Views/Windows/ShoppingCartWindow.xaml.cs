using OnlineStore.Models.Abstract;
using OnlineStore.Models.Concrete;
using OnlineStore.Views.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OnlineStore.Views.Windows
{
    /// <summary>
    /// Interaction logic for ShoppingCartWindow.xaml
    /// </summary>
    public partial class ShoppingCartWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Food> selected_items = new ObservableCollection<Food>();

        public ObservableCollection<Food> Selected_items
        {
            get => selected_items;

            set
            {
                selected_items = value;
                OnPropertyChanged();
            }
        }
        public ShoppingCartWindow(ObservableCollection<Food>? items)
        {
             Selected_items = new ObservableCollection<Food>(items);
            InitializeComponent();
            DataContext = this;

        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
