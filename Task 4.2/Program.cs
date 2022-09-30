using Task;

Shop shop = new(new("Car", 20000), new("Keyboard", 1500), new("Apple", 3), new("Cupboard", 200));
System.Console.WriteLine( Shop.Sum(new("Car", 20000), new("Keyboard", 1500), new("Apple", 3), new("Cupboard", 200)));
var ex_index = shop[0];
var ex_name = shop["Apple"];
//Console.WriteLine($"By index:\n\tName = {ex_index.Name}\n\tValue = {ex_index.Val}");
//Console.WriteLine($"By name:\n\tName = {ex_name.Name}\n\tValue = {ex_name.Val}");



