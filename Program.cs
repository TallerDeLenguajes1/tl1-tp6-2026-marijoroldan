// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);
// Console.WriteLine("Ingrese un número: ");
// string numIngresado = Console.ReadLine();
// int num;
// bool resultado = int.TryParse(numIngresado, out num);

// if (resultado)
// {
//     if (num > 0)
//     {
//         int numInvertido = 0;
//             int aux = num;
//         while (aux != 0)
//         {
//         numInvertido*=10;
//         numInvertido += aux % 10;
//         aux /= 10; 
//         }    
//         Console.WriteLine("Número invertido: "+numInvertido);
//     }
// }else
// {
//     Console.WriteLine("Ingrese un número!!!!"); 
// }

// aca lo hago bien 

////////////////////////////
//// declarar variables ////
////////////////////////////
// string opcion, numPrincipal, num1, num2;
// int opcionValidada;
// double num = 0, numParseado1 = 0, numParseado2 = 0, resultado = 0;
// bool EsOperacionValida, EsNumeroValido, resul1, resul2, todoOK;


// ////////////////////////////
// // pedir y validar operacion
// ////////////////////////////

// do
// {
//     //pedir ingreso
//     Console.WriteLine("Seleccione una opción: ");
//     Console.WriteLine("\n1. Valor Absoluto \n2. Número al cuadrado \n3. Raíz cuadrada \n4. Seno \n5. Coseno \n6.Parte entera de un float \n7. Suma \n8. Resta \n9. Multplicación \n10. División \n11. Menor \n12. Mayor");
//     opcion = Console.ReadLine();
//     EsOperacionValida = int.TryParse(opcion, out opcionValidada);
// } while (!EsOperacionValida || opcionValidada < 1 || opcionValidada > 12); //El while no se detiene si alguna es verdadera. Al contrario, si alguna es verdadera, el ciclo se vuelve a repetir. El ciclo se detiene únicamente cuando absolutamente todas las condiciones son falsas (false), lo que significa que el usuario por fin ingresó todo correctamente. 
// // DIFERENTES CASOS PARA EL WHILE
// // Caso 1: El usuario ingresa "Hola" (Está MAL)
// // !EsOperacionValida se vuelve true (porque TryParse falló).
// // Como ya encontró un true, al operador || no le importa el resto. Todo el while da como resultado true.
// // ¿Qué hace el programa? Como dio true, ¡se repite! (Le vuelve a pedir la opción).

// // Caso 2: El usuario ingresa el número 99 (Está MAL)
// // !EsOperacionValida es false (porque sí pudo convertirse a número).
// // opcionValidada < 1 es false (99 no es menor que 1).
// // opcionValidada > 12 es true (99 sí es mayor que 12).
// // Como hay un true al final, todo el while se vuelve true.
// // ¿Qué hace el programa? Como dio true, ¡se repite!

// // Caso 3: El usuario ingresa el número 5 (¡Está BIEN!)
// // !EsOperacionValida es false (pudo convertirse).
// // opcionValidada < 1 es false (5 no es menor que 1).
// // opcionValidada > 12 es false (5 no es mayor que 12).
// // Como ninguna fue verdadera, el resultado final del while es false.
// // ¿Qué hace el programa? Al dar false, el ciclo SE DETIENE y continúa con el resto del código.


// // si llego hasta aqui es porque la operacion está validada
// // pedir el ingreso de datos
// do
// {
//     if (opcionValidada >= 7) // esto solo si la operacion que usuario ingreso es con dos numeros
//     {
//         //pido y valido dato1
//         //pido y valido dato2
//         Console.WriteLine("Ingrese el primer numero: ");
//     num1 = Console.ReadLine();
//     Console.WriteLine("Ingrese el segundo numero ");
//     num2 = Console.ReadLine();
//     resul1 = double.TryParse(num1, out numParseado1);
//     resul2 = double.TryParse(num2, out numParseado2);
//     if (opcionValidada == 10 && (numParseado1 == 0 || numParseado2 == 0))
//         {
//             todoOK = false;
//             Console.WriteLine("Error: No se puede dividir por cero. Intente con otros números.");
//         }else
//         {
//             todoOK = resul1 && resul2;
//         }
//     }
//     else
//     { // aca es si solo fue una operacion con un valor
//         Console.WriteLine("Ingrese un numero: ");
//         numPrincipal = Console.ReadLine();
//         EsNumeroValido = double.TryParse(numPrincipal, out num);
//         todoOK = EsNumeroValido;
//     }
// } while (!todoOK);

// //opero con los valores ya validados

// resultado = opcionValidada switch
// {
//     1 => Math.Abs(num),
//     2 => Math.Pow(num, 2),
//     3 => Math.Sqrt(num),
//     4 => Math.Sin(num),
//     5 => Math.Cos(num),
//     6 => (int)num, // esto es casteo explícito, estoy forzando a un número con decimales a convertirse en entero
//     7 => numParseado1 + numParseado2,
//     8 => numParseado1 - numParseado2,
//     9 => numParseado1 * numParseado2,
//     10 => Math.Round(Math.Max(numParseado1, numParseado2) / Math.Min(numParseado1, numParseado2), 2),
//     11 => Math.Min(numParseado1,numParseado2),
//     12 => Math.Max(numParseado1,numParseado2),
//     _ => 0
// };

// Console.WriteLine($"El resultado de la operación es: {resultado}");

/////////////////////////////////////////////////////////////////////////
/////////////////////// PUNTO 4 /////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////

//le pido al usuario que ingrese un texto
Console.WriteLine("Ingrese un texto: ");
string textoOriginal = Console.ReadLine();
// reemplazo los espacios del texto original sino el length me va a contar los espacios
string textoSinEspacios = textoOriginal.Replace(" ","");
int longitud = textoSinEspacios.Length;

Console.WriteLine($"El texto ingresado es: {textoOriginal} \nLa cantidad de caracteres es: {longitud}");
// aca le pido al usuario que ingrese otra cadena de caracteres
Console.WriteLine("Ingrese el texto que desea concatenar con el anterior: ");
string texto2 = Console.ReadLine();
// concateno los dos texto con una funcion
string texConcatenado = string.Join(" ",textoOriginal, texto2);

Console.WriteLine($"Textos concatenados : {texConcatenado}");