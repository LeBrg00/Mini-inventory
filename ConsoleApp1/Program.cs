Character player=new Character();
player.characterinventory.look();
Console.WriteLine("Du hittade en hjälm. Vill du ha den?");
string svar =Console.ReadLine();
Console.Clear();
if (svar.ToLower() == "ja")
{
    Armor helmet= new Armor();
    helmet.name="helmet";
    player.characterinventory.items.Add(helmet);
}
player.characterinventory.look();
Console.ReadLine();
