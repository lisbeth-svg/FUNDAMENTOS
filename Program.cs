System.Console.WriteLine("--- INGRESO DE NOTAS DEL CURSO ---");

int x = 0;

while (x == 0)
{
    for (int i = 1; i <= 3; i++)
    {
        System.Console.WriteLine("Ingrese nota " + i + ": ");
        int nota = int.Parse(Console.ReadLine());
    }

    System.Console.WriteLine("¿Necesita ingresar nuevo estudiante? (s/n)");
    char estudiante = char.Parse(Console.ReadLine());

    if (estudiante == 's')
        x = 0;
    else
        x = 1;
}
