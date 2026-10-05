using System.Security.Cryptography.X509Certificates;

public class Character
{
    public int hp=100;
    public string name =""; 
    public Inventory characterinventory=new Inventory();
    public Character()
    {
        Weapon sword=new Weapon();
        Consumable potion=new Consumable();
        sword.name="sword";
        potion.name="potion";
        characterinventory.items.Add(sword);
        characterinventory.items.Add(potion);
    }
}
public class Inventory
{
    public List<Item> items=[];

    public void look()
    {
        Console.WriteLine("Inventory:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine(items[i].name);
        }
    }
}