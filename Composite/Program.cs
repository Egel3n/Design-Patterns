Composite composite1 = new Composite { name = "C1" };
Composite composite2 = new Composite { name = "C2" };
Composite composite3 = new Composite { name = "C3" };

composite1.Add(composite2);
composite2.Add(composite3);

Component.GetComponents(composite1);




abstract class Component
{
    public List<Component> _components;
    public string name;
    public static void GetComponents(Component component)
    {
        Console.WriteLine(component.name);

        if (component._components.Count != 0)
        {
            foreach (var comp in component._components)
            {
                GetComponents(comp);
            }
        }
        else { return;}
    }
    public virtual void Add(Component component)   {throw new NotImplementedException();}
    public virtual void Remove(Component component) {  throw new NotImplementedException(); }

}


class Composite : Component
{
    public Composite()
    {
        _components = new List<Component>();
    }

    public override void Add(Component component) { _components.Add(component); }
    public override void Remove(Component component) { _components.Remove(component); }


}