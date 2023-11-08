using OnlineStore.Models;
using OnlineStore.Models.Abstract;
using OnlineStore.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.ViewModels.PagesViewModels
{
    class MainPageViewModel
    {

        //    static public ObservableCollection<Food> Foods { get; set; }
        //    static public ObservableCollection<Beverage> Beverages { get; set; }
        //    static public ObservableCollection<Meal> Meals { get; set; }
        //    static  public ObservableCollection<FrieOrSide> FriesorSides { get; set; }

        //    public MainPageViewModel()
        //    {


        //        Beverages = new ObservableCollection<Beverage>
        //        {
        //            new Beverage("Coke", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Coke.jpg"),
        //            new Beverage("DietCoke", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\DietCoke.jpg"),
        //            new Beverage("Sprite", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Sprite.jpg"),
        //            new Beverage("Fanta", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Fanta.jpg"),
        //            new Beverage("Lemonade", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\Lemonade.jpg"),
        //            new Beverage("Mango&PineApple", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\MangoPineApple.jpg"),
        //            new Beverage("Strawberry&Banana", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\StrawberryBanana.jpg"),
        //            new Beverage("Sweet Tea", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\SweetTea.jpg"),
        //            new Beverage("DrPepepr", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Beverages\\DrPepepr.jpg"),

        //        };

        //        Meals = new ObservableCollection<Meal>
        //        {
        //            new Meal("Hamburger", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\Hamburger.jpg"),
        //            new Meal("Cheese Burger", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\CheeseBurger.jpg"),
        //            new Meal("Double Cheese", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\DoubleCheeseBuregr.jpg"),
        //            new Meal("McDouble", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\McDouble.jpg"),
        //            new Meal("McCrispy", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\McCrispy.jpg"),
        //            new Meal("Filet-O-Fish", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\Filet-OFish.jpg"),
        //            new Meal("Cheese Bacon", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\CheeseBacon.jpg"),
        //            new Meal("BigMac", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\Header_BigMac_832x472_1-4-product-tile-desktop.jpg"),
        //            new Meal("Double Pounder", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Meals\\DoubleQuarterPounderwithCheese].jpg"),

        //        };

        //        FriesorSides = new ObservableCollection<FrieOrSide>
        //        {
        //            new FrieOrSide("Nuggets", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Nuggets3.jpg"),
        //            new FrieOrSide("10x Nuggets", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Nuggets.jpg"),
        //            new FrieOrSide("Fries", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Fries.jpg"),
        //            new FrieOrSide("BBQ sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\BBQ.jpg"),
        //            new FrieOrSide("Spicy sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Spicy.jpg"),
        //            new FrieOrSide("Ranch sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Ranch.jpg"),
        //            new FrieOrSide("Ketchup sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Ketchup.jpg"),
        //            new FrieOrSide("Mayonnaise sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Mayo.jpg"),
        //            new FrieOrSide("Sour&Sweet sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Sour&Sweet.jpg"),
        //            new FrieOrSide("Mustard sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Mustard.jpg"),
        //            new FrieOrSide("Honey Mustard sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\HoneyMustard.jpg"),
        //            new FrieOrSide("Sweet&Spicy sauce", "150", "Coca-Cola\r\nIngredients: Carbonated Water, High Fructose Corn Syrup, Caramel Color, Natural Flavors, Caffeine.", "1.5$", "../../Multimedia\\Fries&Sides\\Sweet&Spicy.jpg"),

        //        };

        //        Foods = new ObservableCollection<Food>(FriesorSides);

        //    }
        //}}
    }
}
