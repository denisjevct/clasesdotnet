class CDeportista {
    private string nombre;
    private string deporte;
    private float peso, altura;

    public CDeportista() {
        nombre = "";
        deporte = "";
        peso = altura = 0.0F;
    }

    public CDeportista(string nombre, string d, float p, float a)
    {
        this.nombre = nombre;
        this.deporte = d;
        this.peso = p;
        this.altura = a;
    }

    public CDeportista(CDeportista d)
    {
        this.nombre = d.nombre;
        this.deporte = d.deporte;
        this.peso = d.peso;
        this.altura = d.altura;
    }

    public void Leer_Datos() 
    {
        Console.Write("Nombre: ");
        this.nombre = Console.ReadLine();

        Console.Write("Deporte: ");
        this.deporte = Console.ReadLine();

        Console.Write("Peso: ");
        this.peso = float.Parse(Console.ReadLine());
        
        Console.Write("Altura: ");
        this.altura = float.Parse(Console.ReadLine());
    }

    public void Mostrar_Datos()
    {
        Console.WriteLine("Mostrando Datos");
        Console.WriteLine("Nombre: {0}", this.nombre);
        Console.WriteLine("Deporte: {0}", this.deporte);
        Console.WriteLine("Peso: {0}", this.peso);
        Console.WriteLine("Altura: {0}", this.altura);
    }
}