List<string> list = new List<string>();
list.Add("Domates");
list.Add("Patates");
list.Add("Sogan");
list.Add("Biber");
list.Add("Hıyar");
list.Add("Karpuz");
list.Add("Kavun");
list.Add("Acur");
list.Add("Kivi");
list.Add("Ananas");
list.Add("Mango");

Console.WriteLine("For Döngüsü");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
Console.WriteLine("Foreach Döngüsü");
foreach (var item in list)
{
    Console.WriteLine(item);
}