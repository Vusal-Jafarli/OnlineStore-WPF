using OnlineStore.Models.Abstract;
using OnlineStore.Models.Concrete;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using OnlineStore.Views.Windows;

namespace OnlineStore.Views.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page, INotifyPropertyChanged
    {

        private int Order_count = 0;

        public int order_count
        {
            get { return Order_count; }
            set { Order_count = value; OnPropertyChanged(); }
        }


        private ObservableCollection<Food> foods;

        public ObservableCollection<Food> Foods
        {
            get => foods;

            set
            {
                foods = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Beverage> Beverages { get; set; }
        public ObservableCollection<Meal> Meals { get; set; }
        public ObservableCollection<FrieOrSide> FriesorSides { get; set; }



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

        public MainPage()
        {


            Beverages = new ObservableCollection<Beverage>
            {
                new Beverage("Coca-Cola", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Coke.jpg"),
                new Beverage("DietCoke", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\DietCoke.jpg"),
                new Beverage("Sprite", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Sprite.jpg"),
                new Beverage("Fanta", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Fanta.jpg"),
                new Beverage("Lemonade", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Lemonade.jpg"),
                new Beverage("Mango&PineApple", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\MangoPineApple.jpg"),
                new Beverage("Strawberry&Banana", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\StrawberryBanana.jpg"),
                new Beverage("Sweet Tea", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\SweetTea.jpg"),
                new Beverage("DrPepepr", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\DrPepepr.jpg"),

            };

            Meals = new ObservableCollection<Meal>
            {
                new Meal("Hamburger", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\Hamburger.jpg"),
                new Meal("Cheese Burger", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\CheeseBurger.jpg"),
                new Meal("Double Cheese", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\DoubleCheeseBuregr.jpg"),
                new Meal("McDouble", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\McDouble.jpg"),
                new Meal("McCrispy", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\McCrispy.jpg"),
                new Meal("Filet-O-Fish", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\Filet-OFish.jpg"),
                new Meal("Cheese Bacon", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\CheeseBacon.jpg"),
                new Meal("BigMac", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\Header_BigMac_832x472_1-4-product-tile-desktop.jpg"),
                new Meal("Double Pounder", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\DoubleQuarterPounderwithCheese].jpg"),

            };

            FriesorSides = new ObservableCollection<FrieOrSide>
            {
                new FrieOrSide("Nuggets", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Nuggets3.jpg"),
                new FrieOrSide("10x Nuggets", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Nuggets.jpg"),
                new FrieOrSide("Fries", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Fries.jpg"),
                new FrieOrSide("BBQ sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\BBQ.jpg"),
                new FrieOrSide("Spicy sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Spicy.jpg"),
                new FrieOrSide("Ranch sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Ranch.jpg"),
                new FrieOrSide("Ketchup sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Ketchup.jpg"),
                new FrieOrSide("Mayonnaise sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Mayo.jpg"),
                new FrieOrSide("Sour&Sweet sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Sour&Sweet.jpg"),
                new FrieOrSide("Mustard sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Mustard.jpg"),
                new FrieOrSide("Honey Mustard sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\HoneyMustard.jpg"),
                new FrieOrSide("Sweet&Spicy sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Sweet&Spicy.jpg"),

            };

            //Selected_items = new ObservableCollection<Food>
            //{
            //    new FrieOrSide("Abdin", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Nuggets3.jpg"),
            //    new FrieOrSide("Sweet&Spicy sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Sweet&Spicy.jpg"),

            //};
            order_count = 0;
            Foods = new ObservableCollection<Food>(Meals);
            InitializeComponent();
            DataContext = this;

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void fries_sides_button_Click(object sender, RoutedEventArgs e)
        {
            Foods = new ObservableCollection<Food>(FriesorSides);

        }

        private void menu_button_Click(object sender, RoutedEventArgs e)
        {
            Foods = new ObservableCollection<Food>(Meals);
        }

        private void beverage_button_Click(object sender, RoutedEventArgs e)
        {
            Foods = new ObservableCollection<Food>(Beverages);

        }


        private void select_item_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;

            foreach (var item in Foods)
            {
                if(button?.Content.ToString() == item.name)
                {
                    Selected_items.Add(item);
                }
            }
            order_count++;
            //Selected_items.Add();
        }
        private void shopping_cart_click(object sender, RoutedEventArgs e)
        {
            ShoppingCartWindow window = new ShoppingCartWindow(Selected_items);
            window.ShowDialog();
        }
    }
}
