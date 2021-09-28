using System;

namespace Pokemon
{
    class Element
    {
        public string Name { set; get; }
        public int Level { set; get; }
        public int Attack { set; get; }

        public Element(string name, int level, int attack)
        {
            Name = name;
            Level = level;
            Attack = attack;
        }
    }
    class Electric : Element
    {
        public int ElectricAttack { get; set; }

        public Electric(string name, int level, int attack)
            : base(name, level, attack)
        {
            
        }
    }
    class Plant : Element
    {
        public int PlantAttack { get; set; }
        
        public Plant(string name, int level, int attack)
            : base(name, level, attack)
        {
            
        }
    }
    class Fire : Element
    {
        public int FireAttack { get; set; }
        
        public Fire(string name, int level, int attack)
            : base(name, level, attack)
        {
            
        }
    }
    class Water : Element
    {
        public int WaterAttack { get; set; }
        
        public Water(string name, int level, int attack)
            : base(name, level, attack)
        {
            
        }
    }
    class Trainer
    {
        public string Name { get; set; }
        public Pokeball p1 { get; set; } = new Pokeball(1);
        public Pokeball p2 { get; set; } = new Pokeball(2);
        public Pokeball p3 { get; set; } = new Pokeball(3);
        public Pokeball p4 { get; set; } = new Pokeball(4);

        public Trainer(string name)
        {
            this.Name = name;
        }
    }

    class Pokeball
    {
        public bool IsFull { get; set; } = false;
        public int Id { get; set; }
        private Element pokemon;

        public Element Pokemon
        {
            get { return pokemon; }
            set
            {
                if (value != null)
                {
                    this.IsFull = true;
                }
                else
                {
                    this.IsFull = false;
                }
                this.pokemon = value;
            }
        }

        public Pokeball(int id)
        {
            this.Id = id;
        }
        public void PrintInfo()
        {
            if (IsFull)
            {
                Console.WriteLine($"This pokeball is full\nThe pokemon inside is:");
                Console.WriteLine($"Name: {Pokemon.Name}\nAttack: {Pokemon.Attack}");
                Console.WriteLine($"Level: {Pokemon.Level}");
                Console.WriteLine(Pokemon.GetType());
            }
            else
            {
                Console.WriteLine("Nothing is in this pokeball");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trainer t = new Trainer("Ash");
            Console.WriteLine(t.Name);
            Plant pok = new Plant("Grassachu", 69, 420);
            pok.PlantAttack = 666;
            Pokeball balls = new Pokeball(9);
            balls.Pokemon = pok;
            t.p1 = balls;
            t.p1.PrintInfo();
        }
    }
}