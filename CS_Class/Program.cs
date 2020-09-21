using System;

namespace CS_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var pistol = new Weapon();
            pistol.name = "Pistol";
            pistol.SetDamage(10);

            var rifle = new Weapon();
            rifle.name = "Rifle";
            rifle.SetDamage(20);

            pistol.Attack();
            rifle.Attack();
        }
    }
}
