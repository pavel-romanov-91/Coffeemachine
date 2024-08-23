namespace coffeemachine
{
    public class Drink
    {
        public string Name {get;set;}
        public DrinkSize Size {get;set;}
        public int Cups {get;set;}
        public Drink(string name, DrinkSize size, int cups)
        {
            Name = name;
            Size = size;
            Cups = cups;
        }
    }
}