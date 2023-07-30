using zero_to_hero_taner_saydam;

ExampleClass example = new ExampleClass()
{
    Id = 1,
    Property = "test",
    Money = 15.1M,
    isActive = true
};

Console.WriteLine(example.Property);
Console.WriteLine(example.Money);
Console.WriteLine(example.isActive);
example.Add();