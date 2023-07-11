IBuilder builder = new Vegetarian();
BurgerDirector director = new BurgerDirector(builder);


Console.WriteLine("Expensive Vegie Burger Has Come Up");
director.OrderExpensive();
Console.WriteLine(builder.GetBurger().price + " " +  builder.GetBurger().vegie);




interface IBuilder
{
    void cookBurgerCheap();
    void cookBurgerExpensive();
    Burger GetBurger();

}


public class Burger
{
    public decimal price;
    public bool vegie;
}
class Vegetarian:IBuilder
{
    public Burger Burger = new Burger { vegie = true };
    public void cookBurgerCheap()
    {
        Burger.price = (decimal)1.5;
    }

    public Burger GetBurger()
    {
        return Burger;
    }

    public void cookBurgerExpensive()
    {
        Burger.price = 5;
    }
}

class Carnivorous : IBuilder
{
    public Burger Burger = new Burger { vegie = false };
    public void cookBurgerCheap()
    {
        Burger.price = (decimal) 1.5;
    }

    public void cookBurgerExpensive()
    {
        Burger.price = 5;
    }

    public Burger GetBurger()
    {
        return Burger;
    }
}






class BurgerDirector
{
    private IBuilder _builder;
    public BurgerDirector(IBuilder builder)
    {
        this._builder = builder;

    }
    public void OrderExpensive()
    {
        _builder.cookBurgerExpensive();
    } 

    public void OrderCheap()
    {
        _builder.cookBurgerCheap();
    }

}