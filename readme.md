¿String es una tipo por valor o un tipo por referencia?
es un tipo por referencia
Esto significa que cuando creás una cadena de texto, la variable no guarda el texto en sí mismo dentro del Stack (Pila), sino que guarda una dirección de memoria (un puntero) que apunta al lugar real donde está guardado el texto dentro del Heap (Montículo).

La inmutabilidad es justamente ese "seguro de vida" que tiene C#: garantiza que si modificás una variable de texto, no vas a romper ni a cambiar sin querer el valor de otras variables que compartían el mismo texto originalmente.

¿Qué secuencias de escape tiene el tipo string?
Como las cadenas de texto se delimitan con comillas dobles ("), ¿cómo harías si querés meter una comilla adentro del texto, o hacer un salto de línea? Para eso sirven las secuencias de escape: combinaciones de caracteres que empiezan con una barra invertida \ y que la computadora interpreta como una instrucción especial.

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Estos dos símbolos son "superpoderes" que modifican por completo cómo el compilador de C# lee la cadena de texto.
@ Le dice a C#: "Leé todo este texto exactamente tal cual lo escribí, desactivá las secuencias de escape e ignorá los saltos de línea manuales".
Para qué sirve: Evita tener que escribir la doble barra invertida \\ cuando ponés rutas de archivos o expresiones regulares.
$ Le dice a C#: "Activá el modo plantilla. Si ves llaves { }, ejecutá lo que esté adentro y meté su valor acá".
Para qué sirve: Reemplaza la vieja y pesada forma de concatenar textos usando el signo +. Hace que tu código sea muchísimo más corto, limpio y fácil de leer (de hecho, es lo que usamos para mejorar tu Console.WriteLine de la calculadora).