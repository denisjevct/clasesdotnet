class Auto {
    //Atributos
    private string marca;
    private int año;

    //Propiedades
    public string Marca {
        get => marca;
        set => marca = value;
    }

    public int Año {
        get => año;
        set => año = value;
    }

    //Constructores
    public Auto() {}
    public Auto(string m)
    {
        Marca = m;
        Año = 2023;
    }
    public Auto(string m, int a)
    {
        Marca = m;
        Año = a;
    }

    //Métodos
    public string mostrarDatos() {
        return "El auto " + Marca + " es año " + Año;
    }
}