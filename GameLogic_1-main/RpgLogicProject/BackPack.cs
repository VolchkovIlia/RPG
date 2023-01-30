using System;
namespace RpgLogicProject
{

	//Рюкзак
    public class BackPack
    {
        private readonly Item[] items;
        public int maxWeight { get; set; }


        public BackPack(int Freespace)
        {
            items = new Item[Freespace];
            maxWeight = Freespace + 10;
            for (int i = 0; i < Freespace; i++)
            {
                var Item = new Item("Ничего", 0, 0);
                items[i] = Item;
            }
        }


        public int count = 0;
        public void Add(Item item)
        {
            int a = GetWeigth();
            int b = GetSpace();
            Console.WriteLine($"Общий вес = {a}, свободного места - {b}");
            if (a < maxWeight && b > 0 && count < items.Length)
            {
                items[count] = item;
                count++;
                Console.WriteLine("Предмет переместился к вам в рюкзак.");
            }
            else
            {
                Console.WriteLine("Перевес.");
            }
        }

        public int GetWeigth()
        {
            int result = 0;
            for (int i = 0; i < items.Length; i++)
            {
                result += items[i].Weigth;
            }
            return result;
        }
        public int GetSpace()
        {
            int Freespace = items.Length;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Weigth != 0)
                {
                    Freespace--;
                }
                else
                {
                    continue;
                }

            }
            return Freespace;
        }
        public void Looting(int a)
        {
            if (a == 1)
            {
                Random rand = new();
                var Item = new Item(Arrays.loot[rand.Next(0, 10)], rand.Next(1, 3), rand.Next(15, 151));
            start:
                Console.WriteLine();
                Console.Write($"О,немного лута.Возможно пригодится: ");
                Console.Write($"{Item.Name}", Console.ForegroundColor = ConsoleColor.Magenta);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1 - Оценить | 2 - Взять | 3 - Выбросить | 4 - Проверить рюкзак");
                Console.Write("Ответ: ");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 1)
                {
                    Console.WriteLine();
                    Console.Write($"Ну примерно.... ");
                    Console.Write($"{Item.Cost} злотых, ", Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"а вес - {Item.Weigth}.");
                    Console.WriteLine();
                    goto start;
                }
                else if (ans == 2)
                {
                    Add(Item);
                }
                else if (ans == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Вы выкинули предмет");
                }
                else if (ans == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Предмет/ Вес / Цена");
                    Console.WriteLine();
                    for (int i = 0; i < items.Length; i++)
                    {

                        Console.WriteLine($"{items[i].Name} / {items[i].Weigth} / {items[i].Cost}");
                    }
                }
            }
            
        }

    }
}

