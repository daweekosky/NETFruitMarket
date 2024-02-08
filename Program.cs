using FruitMarket;

UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();

List<Fruit> fruits = new List<Fruit>();

for(int i = 0; i < 15; i++)
{
    fruits.Add(Fruit.Create());
}

Console.WriteLine("Fruits:");
foreach(var fruit in fruits)
{
    Console.WriteLine(fruit);
}

var fruitsSorted = fruits.Where(x => x.IsSweet == true).OrderByDescending(x => x.Price);
Console.WriteLine("Sorted fruits:");
foreach (var fruit in fruitsSorted)
{
    Console.WriteLine(fruit);
}