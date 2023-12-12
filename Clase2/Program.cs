/*
 Clase 2: Variables y Tipos de Datos en C#
**Contenido:**
- Declaración y asignación de variables.
- Tipos de datos básicos (int, float, string, bool).
- Conversión de tipos.
*/
using System;

Console.WriteLine("Ingrese su estatura");
double altura;
if(!double.TryParse(Console.ReadLine(), out altura))
{
    Console.WriteLine("No se pueden ingresar letras");
    Environment.Exit(0);
}
int peso;
Console.WriteLine("Ingrese su peso");
if (!int.TryParse(Console.ReadLine(), out peso))
{
    Console.WriteLine("No se pueden ingresar letras");
    Environment.Exit(0);
}

double imc = CalcularImc(peso, altura);

DeterminaGradoIMC(imc);

void DeterminaGradoIMC(double imc)
{
    Console.WriteLine("Resultado: ");

    if (imc < 18.5)
        Console.WriteLine("Peso bajo (desnutricion)");
    else if (imc < 24.9)
        Console.WriteLine("Peso saludable");
    else if (imc < 29.9)
        Console.WriteLine("Sobrepeso");
    else if (imc < 34.9)
        Console.WriteLine("Obesidad");
    
}

double CalcularImc(int peso, double altura)
{
    return peso / (altura * altura);
}