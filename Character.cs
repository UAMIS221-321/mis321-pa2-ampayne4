using System.Diagnostics;
using System.Security.Cryptography;
using mis321_pa2_ampayne4.Interfaces;
using System;

namespace mis321_pa2_ampayne4
{
    public class Character
    {
        public string name {get;set;}
        public static Random rnd = new Random();
        public int maxPower {get;set;}
        public double health {get;set;}
        public int attackStrength {get;set;}
        public int defPower {get;set;}
        public double typeBonus {get;set;}
        public IAttackBehavior attackBehavior {get;set;}

        public double Attack(Player attacker, Player defender)
        {
            double attack = (attacker.character.attackStrength - defender.character.defPower) * attacker.character.typeBonus;
            if (attack > 0)
            {
                return attack;
            }
            else
            {
                return 1;
            }
            //Console.WriteLine($"{attacker.character.name} attacked {defender.character.name} with an attack power of {attacker.character.attackStrength}. This reduces {defender.character.name}'s health to {defender.character.health}");
        }

        // public void Defend(Player player)
        // {

        // }
    }
}