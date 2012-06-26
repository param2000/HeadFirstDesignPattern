using PatternsCore.Composite;

namespace PatternAtWork.Composite
{
    public class CompositePattern
    {
        public CompositePattern()
        {
            MenuComponent pancakeMenu = new Menu("Pancake House Menu","Breakfast");
            MenuComponent dinerMenu = new Menu("Diner Menu","Lunch");
            MenuComponent cafeMenu = new Menu("Cafe Menu","Dinner");
            MenuComponent dessertMenu = new Menu("Dessert Menu","Dessert Offcourse!");

            MenuComponent allMenus= new Menu("All Menus","all menu's combined");

            allMenus.Add(pancakeMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);
            
            //breakfast
            pancakeMenu.Add(new MenuItem("Pancake","Pancake with honey",true,1.99));
            pancakeMenu.Add(new MenuItem("K&B Pancake","Pancake with scrambled eggs",true,1.99));
            pancakeMenu.Add(new MenuItem("French toast","French Toasts with organic honey",true,1.99));
            
            
            cafeMenu.Add(new MenuItem("Turkey Burger","Burger with marinated turkey with hot souce!", false,3.37));
            cafeMenu.Add(new MenuItem("Soup of the day","soup with side potato", false,3.37));

            dinerMenu.Add(new MenuItem("Pasta","spaghetti with marinara souce",true,3.99));
            dinerMenu.Add(new MenuItem("BLT","Bacon with lettuce",true,3.99));
            dinerMenu.Add(dessertMenu);
            
            dessertMenu.Add(new MenuItem("apple pie","Apple pie with flaky crust",true,2.99));
            dessertMenu.Add(new MenuItem("Pineapple Icecream","Ice cream with pineapple toppings",true,2.99));



            CompositeWaitress waitress = new CompositeWaitress(allMenus);

            waitress.PrintMenu();




        }
    }
}