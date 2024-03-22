using System;

namespace MyGame
{
    public class Enemy
    {
        static int powerUpCount;
        private string name;
        private float health;
        private float shield;

        public float GetPowerUp()
        {
            return powerUpCount
        }

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
        {
            return health;
        }
        public GetShield()
        {
            return shield;
        }
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

        public void PickupPowerUp(PowerUp pwu, float fa)
        {
            powerUpCount++;
            if (pwu == PowerUp.Health)
            {
                health += fa;
                if (health > 100) health = 100;
            }
            else if (pwu == PowerUp.Shield)
            {
                shield += fa;
                if (shield > 100) shield = 100;
            }
        }

        static Enemy()
        {
            powerUpCount = 0;
        }
    }
}