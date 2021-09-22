using System;

namespace Tests
{
    class Element
    {
        public string Name { set; get; }
        public int Level { set; get; }
        public int Attack { set; get; }
    }
    class Electric : Element
    {
        public int ElectricAttack { get; set; }
    }
    class Plant : Element
    {
        public int PlantAttack { get; set; }
    }
    class Fire : Element
    {
        public int FireAttack { get; set; }
    }
    class Water : Element
    {
        public int WaterAttack { get; set; }
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
        public bool isFull { get; set; } = false;
        public int id { get; set; }
        private Element pokemon;

        public Element Pokemon
        {
            get { return pokemon; }
            set
            {
                if (value != null)
                {
                    this.isFull = true;
                }
                else
                {
                    this.isFull = false;
                }
                this.pokemon = value;
            }
        }

        public Pokeball(int id)
        {
            this.id = id;
        }
        public void PrintInfo()
        {
            if (isFull)
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
            Plant pok = new Plant();
            pok.Name = "Grassachu";
            pok.Level = 69;
            pok.Attack = 420;
            pok.PlantAttack = 666;
            Pokeball balls = new Pokeball(9);
            balls.Pokemon = pok;
            t.p1 = balls;
            t.p1.PrintInfo();
        }
    }
}
