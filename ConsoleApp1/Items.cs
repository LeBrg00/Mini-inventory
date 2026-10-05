public class Item
{
    public string name="";
    public float Wheight;
}
public class Weapon: Item
{
    public int maxDamage;
    public int minDamage;

    public int attack()
    {
        return minDamage+ Random.Shared.Next(maxDamage-minDamage);
    }
}
public class Armor: Item
{
    float protection;
}
public class Consumable: Item
{
    int usesMax;
    int usesCurrent;
    public void use()
    {

    }
}