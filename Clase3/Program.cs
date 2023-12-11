/*
 Clase 3: Estructuras de Control de Flujo
**Contenido:**

- Uso de condicionales (if, else if, else).
- Bucles (for, while, foreach).
- Switch.

Ejercicio demo:1
Escribir un programa que pida al usuario un número e indique si positivo o negativo.
Ejercicio demo:2
Escribir un programa cuente hasta el numero indicado imprimiendo por consola el valor actual. usando sentencia for.
Ejercicio demo:3
Escribir un programa cuente hasta el numero indicado imprimiendo por consola el valor actual. usando sentencia while.
Ejercicio demo:4
Escribir un programa que al ingresar un valor numerico del 1 al 7 devuelva el dia de la semana correspondiente.
 */


using System.Timers;

Console.WriteLine("Ingresa un numero");
var imput = Console.ReadLine();
int numero;
if(!int.TryParse(imput,out numero))
{
	Console.WriteLine("No tiene que tener letras!");
	Environment.Exit(0);
}
if (numero > 0)
	Console.WriteLine($"El numero {numero} es un entero positivo");
if (numero < 0)
	Console.WriteLine($"El numero {numero} es un entero negativo");

Console.ReadLine();














/*using System.Security.Cryptography;
bool usuarioEncontroElNum = false;
int numeroMisterioso = RandomNumberGenerator.GetInt32(0, 100);

while (!usuarioEncontroElNum)
{
	
	Console.WriteLine("prueba un numero");
	var imput = Console.ReadLine();
	int result;
	if(!int.TryParse(imput , out result))
	{
		Console.WriteLine("No se puede ingresar texto!");
		Environment.Exit(result);
	}

	if (result > numeroMisterioso)
		{
			Console.WriteLine("Prueba un numero mas chico");
			Console.ReadKey();
			Console.Clear();
		}
	else if (result < numeroMisterioso)
		{
			Console.WriteLine("Prueba un numero mas grande");
			Console.ReadKey();
			Console.Clear();
		}
	else 
		{
			Console.WriteLine("Encontraste el numero correcto!!");
			usuarioEncontroElNum = true;
		}
}*/