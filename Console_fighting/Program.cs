using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_fighting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerHealth = 100;
            int playerEnergy = 100;

            int enemyHealth = 100;
            int enemyEnergy = 100;

            int action = -1;

            while (enemyHealth > 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("******************************************************");
                Console.WriteLine("****************** Console Fighting ******************");
                Console.WriteLine("******************************************************");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("Жизни: " + playerHealth + "\t\t\t Жизни вируса: " + enemyHealth);
                Console.WriteLine("Энергия: " + playerEnergy + "\t\t\t Энергия вируса: " + enemyEnergy);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("1. Почистить папку Temp (20 урона, -10 энергии)");
                Console.WriteLine("2. Использовать Касперского (30 урона, -40 энергии)");
                Console.WriteLine("3. Выпить кофе (+20 энергии)");
                Console.WriteLine("4. Заказать доставку пиццы (+30 жизни, -20 энергии)");

                string data = "";
                while(data == "")
                {
                    data = Console.ReadLine();
                    if (data == "") Console.WriteLine("Вы неверно ввели данные!!!");
                }
                action = int.Parse(data);

                Console.Clear();
                switch (action)
                {
                    case 1:
                        if (playerEnergy >= 10)
                        {
                            enemyHealth -= 20;
                            playerEnergy -= 10;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("***** Вы нанесли 20 урона вирусу *****");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("----- Не достаточно энергии. Ты пропустил этот ход! -----");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        if (playerEnergy >= 40)
                        {
                            enemyHealth -= 30;
                            playerEnergy -= 40;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("***** Вы нанесли 30 урона вирусу *****");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("----- Не достаточно энергии. Ты пропустил этот ход! -----");
                            Console.ResetColor();
                        }
                        break;
                    case 3:
                        playerEnergy += 20;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("***** Вы увеличили свою энергию на 20 *****");
                        Console.ResetColor();
                        break;
                    case 4:
                        if (playerEnergy >= 20)
                        {
                            playerEnergy -= 20;
                            playerHealth += 30;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("***** Вы увеличили свое здоровье на 30 *****");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("----- Не достаточно энергии. Ты пропустил этот ход! -----");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный ввод!!! Вы пропускаете ход!");
                        Console.ResetColor();
                        break;
                }
                if (enemyHealth <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("****************************");
                    Console.WriteLine("***** Вы ПОБЕДИТЕЛЬ!!! *****");
                    Console.WriteLine("****************************");
                    Console.ResetColor();
                    break;
                    
                }

                action = random.Next(1,4);
                if (enemyEnergy < 40)
                {
                    action = 3;
                }
                if (enemyHealth <= 30 && enemyEnergy >= 20)
                {
                    action = 4;
                }
                switch (action)
                {
                    case 1:
                        if (enemyEnergy >= 10)
                        {
                            playerHealth -= 20;
                            enemyEnergy -= 10;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("----- Вы получили 20 урона -----");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        if (enemyEnergy >= 40)
                        {
                            playerHealth -= 30;
                            enemyEnergy -= 40;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("----- Вы получили 30 урона -----");
                            Console.ResetColor();
                        }
                        break;
                    case 3:
                        enemyEnergy += 20;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("----- Вирус увеличил свою энергию на 20 -----");
                        Console.ResetColor();
                        break;
                    case 4:
                        if (enemyEnergy >= 20)
                        {
                            enemyEnergy -= 20;
                            enemyHealth += 30;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("----- Вирус увеличил свое здоровье на 30 -----");
                            Console.ResetColor();
                        }
                        break;
                        
                }
                if (playerHealth <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("****************************");
                    Console.WriteLine("***** Вы ПРОИГРАЛИ !!! *****");
                    Console.WriteLine("****************************");
                    Console.ResetColor();
                    break;
                }

            }

        }
    }
}
