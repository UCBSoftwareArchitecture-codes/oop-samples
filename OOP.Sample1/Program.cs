using System;

namespace OOP.Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraccion y Encapsulacion.
            Perro firulais=new Perro();
            Console.WriteLine(firulais.Ladrar()); /// 
            firulais.Comer();
            Console.WriteLine(firulais.Ladrar()); /// 

            //Herencia y Polimorfismo.
            Animal animal= new Perro();
            ICuadrupedo cuadrupedo=new Perro();
            
        }
    }
}
