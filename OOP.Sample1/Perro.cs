namespace OOP.Sample1
{
    public class Perro : Animal, ICuadrupedo, IMamifero
    {

        private string _estadoDeAnimo;

        public string Nombre {get; set;}
        public string Raza {get; set;}
        public double Peso {get; set;}
        public int Edad {get; set;}

        public Perro()
        {
            _estadoDeAnimo="neutro";
            Edad=2;
        }


        public void Comer()
        {
            _estadoDeAnimo="feliz";

        }
        public string Ladrar()
        {

            Mover();
            return "wow estoy..."+_estadoDeAnimo;

        }
        public void Dormir()
        {
            _tipo="";

        }
        public void Crecer()
        {
            Edad++;

        }

        public void IrBano()
        {
            
        }

        public int NumeroPatas()
        {
            return 4;
        }

        
    }
}