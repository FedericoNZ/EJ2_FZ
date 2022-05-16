

int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1,21);
int numeroUsuario = 0;
int nIntentos = 1;
bool acerto = false;

while (acerto == false)
{
    Console.WriteLine("Ingrese un número y adivine el número secreto entre 1 y 20:");

    while (!int.TryParse(Console.ReadLine(), out numeroUsuario))
    {
        Console.WriteLine("\nEl carácter ingresado no es un número válido,");
        Console.WriteLine("Ingrese un número y adivine el número secreto entre 1 y 20:");
        acerto = false;
    }

    if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("\nEl número ingresado es MAYOR que el número secreto,");
        Console.WriteLine("pero aún podés seguir intentándolo.\n\n");
        nIntentos++;
        acerto = false;
    }
    else if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("\nEl número ingresado es MENOR que el número secreto,");
        Console.WriteLine("pero aún podés seguir intentándolo.\n\n");
        nIntentos++;
        acerto = false;
    }
    else if (numeroUsuario == numeroSecreto)
    {
        Console.WriteLine("\nFelicitaciones,");
        Console.WriteLine($"has adivinado el número secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo lograste en {nIntentos} intentos!");
        acerto = true;
    }
}
