using System;
using RpgGame.Class.Characters;

namespace RpgGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Character();
            warrior.Name = "Jhon Snow";
            warrior.Health = 100;

            //sofre o ataque do adversario
            var damages = 20;
            warrior.Health = warrior.Health - damages;
     

        }
    }
}
