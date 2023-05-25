class Persona
{
    //Atributos
    private string nombre;
    private int edad;
    private bool graduado;

    //Propiedades
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }
    public int Edad
    {
        get => edad;
        set => edad = value;
    }
    public bool Graduado
    {
        get => graduado;
        set => graduado = value;
    }

    //Constructores
    public Persona() { }

    public Persona(string n, int e, bool g)
    {
        Nombre = n;
        Edad = e;
        Graduado = g;
    }

    //Métodos
    public bool EsMayorDeEdad()
    {
        return Edad >= 18;
    }
}