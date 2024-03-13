using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizards
{

    class Class_Russ
    {
        public static int health = 100;
        public static int saint_power = 100;
        public static int strength = 25;
        public static double crit_chance = 0.5;
        public static double crit_multiplier = 1.5;
        public static int money = 0;

        private Random random = new Random();
        private int baseDamage = 10;
        private double critChance = 0.228;

        public void Attack()
        {
            int damage = CalculateDamage();
            Console.WriteLine($"Нанесён урон: {damage}");
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

