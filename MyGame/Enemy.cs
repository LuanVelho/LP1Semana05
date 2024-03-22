using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //Construtor
        public Enemy (string name)
        {
            this.name = SetName();
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        
        public GetHealth()
        public GetShield()
        public SetName()
        {
            novonome = Console.ReadLine("Qual será o nome?");
            if (novonome.lenth > 8)
            {
                novonome.lenth = 8;
            }
            name = novonome;
            Console.WriteLine(name);
        }
    }
}