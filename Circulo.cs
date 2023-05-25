namespace Clase1
{
    class Circulo
    {
        // Miembros privados
        private double x, y; // coordenadas del centro
        private double radio; // radio del circulo

        // Miembros protegidos
        protected void MsgEsNegativo()
        {
            Console.WriteLine("El radio es negativo. Se convierte a positivo.");
        }

        // Miembros públicos
        public Circulo() { } // constructor sin parámetros
        public Circulo(double ex, double cy, double r)
        {
            x = ex; Y = cy;
            if (r < 0)
            {
                MsgEsNegativo();
                r = -r;
            }
            radio = r;
        }

        public double Y { get => y; set => y = value; }
        public double X { get => x; set => x = value; }

        public double LongCircunferencia()
        {
            return 2 * Math.PI * radio;
        }
        public double AreaCirculo()
        {
            return Math.PI * radio * radio;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}