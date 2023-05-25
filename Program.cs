CDeportista [] deportistas = new CDeportista[3];

for (int i = 0; i < deportistas.Length; i++)
{   
    deportistas[i] = new CDeportista();
    deportistas[i].Leer_Datos();
}
    

foreach (var item in deportistas)
    item.Mostrar_Datos();

