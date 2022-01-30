// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int edadMayor = 0;
int edadMenor = 0;
int[] edades = {21,22,23,24,25,26,27,28,29,30};

Console.WriteLine("Factorial: " + Factorial(5));


// 1 Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.
int[] FuncionTabla(int numeroTabla)
{

    int[] tabla = new int[10];

    for (int s = 1; s < 11; s++)
    {

        tabla[s - 1] = s * numeroTabla;

    }

    return tabla;

}


// 2 Hacer un programa que calcule el resultado de un número elevado a cualquier potencia.

int FuncionExponencial(int numero, int exponente)
{
    int resultado = numero;

    if (exponente == 1)
    {
        return numero;
    }
    else if (exponente == 0)
    {
        return 1;
    }
    else if (exponente < 0)
    {
        return 0;
    }
    else
    {
        for (int s = 1; s < exponente; s++)
            resultado = resultado * numero;
    }
    return resultado;
}




// 5 Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven.


int CalculadoraPromedio(int[] edades)
{

    int totalEdades = 0;

    for (int s = 0; s < edades.GetLength(0); s++)
    {
        totalEdades += edades[s];
        setEdadMayor(edades[s]);
        setEdadMenor(edades[s]);
    }
    
    var promedio = totalEdades / edades.GetLength(0);
   
    return promedio;
}

void setEdadMayor(int edad)
{
    if (edadMayor < edad)
    {
        edadMayor = edad;
    }
}

void setEdadMenor(int edad)
{
    if (edad < edadMenor || edadMenor == 0)
    {
        edadMenor = edad;
    }
}






// 4 Hacer una función que calcule el factorial de un número.
int Factorial(int n){

  if (n == 0){

     return 1;

  }else{

     return n * Factorial(n - 1);
  }
}


// 5 Hacer una función que dado un número nos regrese una cadena donde se encuentre escrito en palabras.
