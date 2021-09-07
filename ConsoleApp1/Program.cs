using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero master = new Hero(25);
            Hero noob = new Hero(15);
            master.doDamage(6, noob);
            Console.WriteLine(noob.health);
            Console.WriteLine(noob.heal(true));
        }
        class Hero
        {
            public int maxHealth;
            public int health;
            public Hero(int hp)
            {
                maxHealth = hp;
                health = hp;
            }
            public void doDamage(int damage, Hero other)
            {
                other.health -= damage;
            }

            public int heal(bool largeHealthPack)
            {
                if (largeHealthPack)
                {
                    health += 10;
                }
                else
                {
                    health += 5;
                }
                if (health > maxHealth)
                {
                    health = maxHealth;
                }
                return health;
            }
        }
    }
}
