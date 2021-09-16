using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon masterSword = new Weapon("Legendary Diamond Sword", 69);
            Weapon noobToy = new Weapon("Trash Wooden Sword", 1);

            Hero mafiaBoss = new Hero(25, masterSword);
            Hero noob = new Hero(15, noobToy);

            noob.doDamage(mafiaBoss);
            mafiaBoss.doDamage(noob);

            Console.WriteLine(noob.health);
            Console.WriteLine(noob.heal(true));
        }

        class Weapon
        {
            public string weaponType;
            public int weaponDamage;
            public Weapon(string type, int damage)
            {
                weaponType = type;
                weaponDamage = damage;
            }
        }
        class Hero
        {
            public int maxHealth;
            public int health;
            public Weapon heroWeapon;
            public Hero(int hp, Weapon heroWeapon)
            {
                maxHealth = hp;
                health = hp;
                this.heroWeapon = heroWeapon;
            }
            public void doDamage(Hero other)
            {
                other.health -= heroWeapon.weaponDamage;
                if (other.health < 0)
                {
                    other.health = 0;
                }
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
