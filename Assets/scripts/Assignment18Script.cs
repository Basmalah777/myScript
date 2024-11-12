using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


namespace Assignment18
{
    public struct Position
    {
        public float X, Y, Z;


        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public void printPosition()
        {
            Debug.Log("Position: (" + X + ", " + Y + ", " + Z + ")");
        }
    }

    public class Character
    {
        public string name;
        private int health;
        protected Position position;


        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0))
        {
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("Name: " + name);
            Debug.Log("Health: " + health);
            position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            PerformAttack(damage, target, null);
        }

        public void Attack(int damage, Character target, string attackType)
        {
            PerformAttack(damage, target, attackType);
        }

        private void PerformAttack(int damage, Character target, string attackType)
        {

            target.Health -= damage;

            if (!string.IsNullOrEmpty(attackType))
            {
                Debug.Log(this.name + " attacked  " + target.name + " with " + attackType + " for " + damage + " damage.");
            }
            else
            {
                Debug.Log(this.name + " attacked " + target.name + " for " + damage + " damage.");
            }
        }



    }

    public class Soldier : Character
    {
        public Soldier(string name, int health, Position position) : base(name, health, position)
        {
        }

        public Soldier() : base("Default Soldier", 100, new Position(0, 0, 0))
        {
        }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }

    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position)
        {
        }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }


}
