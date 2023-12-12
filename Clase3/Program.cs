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


Console.WriteLine("Ingrese un numero del 1 al 7 para obtener el dia de la semana correspondiente");
int valor = int.Parse(Console.ReadLine()!);
/*
lunes = 1 
martes = 2
miercoles = 3
jueves = 4 
viernes = 5
sabado = 6
domingo = 7
 */
//if (valor == 1)
//	Console.WriteLine("lunes");
//if (valor == 2)
//    Console.WriteLine("martes");
//if (valor == 3)
//    Console.WriteLine("miercoles");
//if (valor == 4)
//    Console.WriteLine("jueves");
//if (valor == 5)
//    Console.WriteLine("Viernes");
//if (valor == 6)
//    Console.WriteLine("Sabado");
//if (valor == 7)
//    Console.WriteLine("Domingo");
string dia = string.Empty;
switch (valor)
{
	case 1:
		dia = "Lunes";
		break;
    case 2:
        dia = "Martes";
        break;
    case 3:
        dia = "Miercoles";
        break;
    case 4:
        dia = "Jueves";
        break;
    case 5:
        dia = "Viernes";
        break;
    case 6:
        dia = "Sabado";
        break;
    case 7:
        dia = "Domingo";
        break;
}

Console.WriteLine("El dia seleccionado es "+ dia);



//Console.WriteLine("Ingrese un numero");
//int numero = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Contando hasta " + numero + ":");

//int contador = 1;

//while (contador <= numero)
//{
//	Console.Write(contador);
//	contador++;
//}

//Console.WriteLine("Ingrese un numero");
//int numero = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Contando hasta " + numero +":");
//for(int i = 1;i<= numero; i++)
//{
//	Console.Write(i);
//}













//Console.WriteLine("Ingrese un numero");
//int numero;

//	try
//	{
//		numero = int.Parse(Console.ReadLine());
//		if (numero < 0)
//			Console.WriteLine("El numero es negativo");

//		if (numero > 0)
//			Console.WriteLine("El numero es positivo");

//	}
//	catch (Exception ex)
//	{

//		Console.WriteLine(ex.Message);
//	}












/*using System.Timers;

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

Console.ReadLine();*/














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