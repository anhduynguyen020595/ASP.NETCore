using System;
namespace CS_Class
{
    public class Weapon
    {
        public string name;
        int damage;

        public Weapon (){
            damage = 1;
        }

        public Weapon(string name, int damage){
            this.name = name;
            SetDamage(damage);
        }

        public void SetDamage(int level){
            this.damage = level;
        }

        public void Attack(){
            Console.Write(name + ": ");
            for (int i = 0; i < damage; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}