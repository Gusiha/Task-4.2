using Task;


int digit1 = 20;
int digit2 = 60;

// Метод обмена по ссылке
Goods.Swap(ref digit1, ref digit2);

// Работа индексаторов
Shop shop = new(new("Car", 20000), new("Keyboard", 1500), new("Apple", 3), new("Cupboard", 200));
var ex_index = shop[0];
var ex_name = shop["Apple"];

// Метод суммы с бесконечным кол-вом параметров
Console.WriteLine( Shop.Sum(new("Car", 20000), new("Keyboard", 1500), new("Apple", 3), new("Cupboard", 200)));




//Console.WriteLine($"By name:\n\tName = {ex_name.Name}\n\tValue = {ex_name.Val}");
//Console.WriteLine($"By index:\n\tName = {ex_index.Name}\n\tValue = {ex_index.Val}");
