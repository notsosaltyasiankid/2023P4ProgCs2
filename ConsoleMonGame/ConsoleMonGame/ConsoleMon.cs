﻿namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        private List<Skill> skills;

        internal void TakeDamage(int damage)
        {
            health -= damage;
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
       
    }

    
}