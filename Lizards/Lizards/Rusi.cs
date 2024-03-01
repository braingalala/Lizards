using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizards
{

    class Rusi
    {

        public static int hp = 100;
        public static int svs = 100;
        public static int st = 100;
        public static int money = 0;

    private Random random = new Random();
        private int baseDamage = 10;
        private double critChance = 0.2;

        public void Attack()
        {
            int damage = CalculateDamage();
            Console.WriteLine($"Получен урон: {damage}");
        }
        private int CalculateDamage()
        {
            int damage = baseDamage;
            if (random.NextDouble() < this.critChance)
            {
                damage *= 2;
                Console.WriteLine("Критический урон! Урон удвоен!");
            }
            return damage;
        }
    }
}

