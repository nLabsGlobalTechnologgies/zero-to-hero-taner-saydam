//string name, surname, result;
//name = "Taner";
//surname = "Saydam";
//result = $"{name} - {surname}";

//Console.WriteLine(result);

//double num1 = 10010.1054654;
//decimal num2 = 10.19213112M;
//int num4 = 25;
//decimal num3 = Convert.ToDecimal(num1) + num2 * num4;
//string money = string.Format("{0:C}", num3);
//Console.WriteLine(money);

int num1 = 4;
var result = (num1 > 5 && num1 < 200 || num1 == 5) ? "Sayı1 200'den Küçük yada eşit 5'e" : "Sayı1 5'den Küçük";
Console.WriteLine(result);