using FruitMarket;

List<Fruit> fruits = new List<Fruit>();

for(int i = 0; i < 15; i++)
{
    fruits.Add(Fruit.Create());
}

foreach(var fruit in fruits)
{
    Console.WriteLine(fruit);
}