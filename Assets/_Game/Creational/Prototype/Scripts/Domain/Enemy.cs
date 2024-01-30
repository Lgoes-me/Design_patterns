namespace Prototype.Domain
{
    public class Enemy
    {
        public string Name { get; }
        public int Health { get; }

        public Enemy(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public Enemy Clone()
        {
            return new Enemy(Name , Health);
        }
    }
}