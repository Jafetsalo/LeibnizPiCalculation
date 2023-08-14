// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por Jafet :D");

Console.WriteLine("Por favor escribe un número entero de 1 a 201");
int entradaN = int.Parse(Console.ReadLine());

double vectorLeibniz = 0;
int indiceVector = 0;

//Ciclo que aumenta 1 a 1 hasta el valor máximo (entradaN)
for (int posibleDenominador = 0; posibleDenominador<entradaN ; posibleDenominador++) 
{
    if (posibleDenominador % 2 == 0)
    {
        //Verificación 1: Denominador: PAR
    }
    else 
    {
        //Verificación 1: Denominador: IMPAR

        if (indiceVector % 2 == 0) 
        {
            //verificación 2: Posición: PAR
            vectorLeibniz += 1.0/posibleDenominador;
            indiceVector++;
            Console.WriteLine($"Se añade el denominador 1/{posibleDenominador}, con posición {indiceVector} el resultado es: {vectorLeibniz.ToString()}");
        }
        else
        {
            //verificación 2: Posición: IMPAR
            vectorLeibniz += -1.0/posibleDenominador;
            indiceVector++;

            Console.WriteLine($"Se añade el denominador -1/{posibleDenominador}, con posición {indiceVector} el resultado es: {vectorLeibniz}");
        }
    }


    
}

vectorLeibniz = vectorLeibniz*4;
Console.WriteLine($"Con estos parámetros, un número N de {entradaN} el resultado es: {vectorLeibniz}");



