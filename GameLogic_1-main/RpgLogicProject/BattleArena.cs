using System;
namespace RpgLogicProject
{
    public class BattleArena
    {
        public Enemy Enemy { get; set; }
        public Hero Hero { get; set; }
        public Weapon Weapon { get; set; }


        public BattleArena(Enemy enemy, Hero hero, Weapon weapon)
        {
            Enemy = enemy;
            Hero = hero;
            Weapon = weapon;
        }

        public int Battle()
        {

            do
            {
            restart:
                var rand = new Random();
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Ваше здоровье {Hero.Hp}");
                Console.WriteLine($"Здоровье противника {Enemy.Hp}");
                Console.WriteLine($"Вы нанесли урон противнику: {Hero.Damage+ Weapon.Damage}");
                Console.WriteLine("------------------------------------");
                Enemy.Hp -= (Hero.Damage + Weapon.Damage);
                if (Enemy.Hp <= 0)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Вы победили врага!");
                    Console.WriteLine("------------------------------------");
                    return 1;
                }

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Вы получили урон: {Enemy.Damage}");
                Console.WriteLine("------------------------------------");
                Hero.Hp -= Enemy.Damage;
                if (Hero.Hp <= 0)
                {
                    Console.WriteLine("В следующий раз получится...");
                    Console.WriteLine("------------------------------------");
                    return 0;
                }
                else { goto restart; }

            }
            while (Enemy.Hp > 0 && Hero.Hp > 0);


            //Реализовать пошаговый бой до окончании жизни одного из участников битвы
            //Вернуть 1 в случае победы. 0 - поражение

            
        }
    }

}

   


