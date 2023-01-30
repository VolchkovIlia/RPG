using RpgLogicProject;

//Инициализировать классы. И начать битву 
var rand= new Random();
Console.WriteLine("Добро пожалавать на арену герой!");
Console.WriteLine("Представься перед боем");
Console.Write("Меня зовут:");
string name=Convert.ToString(Console.ReadLine());
var Hero = new Hero(name, 1, 100);
Console.WriteLine("------------------------------------");
var Weapon = new Weapon("Рапира судьбы", 15);
Console.WriteLine($"Отлично! Твоим оружием будет: {Weapon.Name}");
var Enemy = new Enemy(Arrays.monsters[rand.Next(0, 10)], Hero.Level + rand.Next(0, 1), rand.Next(0, 100), rand.Next(0, 50));
Console.WriteLine($"Теперь определимся с твоим противником.Пусть это будет: {Enemy.Name}");
Console.WriteLine("------------------------------------");
Console.WriteLine("Готов к бою?");
Console.WriteLine("1-Да/2-Нет");
int answer = int.Parse(Console.ReadLine());
Console.WriteLine("------------------------------------");
if (answer == 1 )
{   
   
    Console.WriteLine("Отлично!Да начнётся бой!");
    var BattleArena = new BattleArena(Enemy,Hero,Weapon);
    var BackPack = new BackPack(10);
    BackPack.Looting(BattleArena.Battle());
}
else if (answer == 2)
{ 
    Console.WriteLine("Убегаешь с поля боя?Я думал ты воин,а по итогу обычный дезертир... ");
    Console.WriteLine("Знаешь,обычноя не даю шансов на повторный выбор.Но бизнес есть бизнес,а мне нужно шоу.Поэтому вот  тебе два варианта:");
    Console.WriteLine("1-Уйти,2-Выйти на поле боя.Выбор варианта за тобой");
    res:
    Console.WriteLine("Я выберу:");
    int answer1 = int.Parse(Console.ReadLine());
    if(answer1==1)
    {
        Console.WriteLine($"{Hero.Name},я думал ты умнее.У тебя был шанс стать великим бойцом,но ты выбрал бег.Проваливай чтобы мои глаза тебя не видели!");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Игра окончена...");
    }
    if(answer1==2)
    {
        Console.WriteLine($"Я знал , что ты умный малый {Hero.Name}");
        Console.WriteLine("Бой начинается прямо сейчас!");
        var BattleArena = new BattleArena(Enemy, Hero, Weapon);
        var BackPack = new BackPack(10);
        BackPack.Looting(BattleArena.Battle());

    }
    else
    {
        Console.WriteLine("БЕЗ ИМПРОВИЗАЦИИ!!");
        
    }
    
}
else
{
    Console.WriteLine("Парень , мы так не договаривались.От сюжета не отходим!");
}








///////////////////////////////////////////////////////////////////
// Дополнительное задание на 5.
// Реализовать механизм лута предметов с противника в случае победы
///////////////////////////////////////////////////////////////////