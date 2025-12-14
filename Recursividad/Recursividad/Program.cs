using Recursividad;

MetodoRecursividad mimetodo = new MetodoRecursividad();

Console.WriteLine("¿A qué número le quieres sacar factorial?");
int factorial = int.Parse(Console.ReadLine());

int resultado = mimetodo.FactorialRecursividad(factorial);

Console.WriteLine("El factorial es: " + resultado);
