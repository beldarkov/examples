Console.Write("Введите Ваше имя: ");
string name = Console.ReadLine(); 
if(name.ToLower() == "маша") {
    Console.Write("Ура, это " + name);
} else {
    Console.Write("Привет, " + name);
}