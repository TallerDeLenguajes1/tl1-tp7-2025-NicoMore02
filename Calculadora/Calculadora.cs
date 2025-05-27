namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public double Dato
        {
            get => dato;
        }

        public void suma(double valor)
        {
            dato += valor;
        }

        public void resta(double valor)
        {
            dato -= valor;
        }

        public void multiplicacion(double valor)
        {
            dato *= valor;
        }

        public void division(double valor)
        {
            if (valor != 0)
            {
                dato /= valor;
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0");
            }
        }

        public void limpiar()
        {
            dato = 0;
        }
    }
}