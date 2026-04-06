Definir n1, n2, n3, n4, n5, promedio Como Real

Escribir "Ingrese la nota 1:"
Leer n1
Escribir "Ingrese la nota 2:"
Leer n2
Escribir "Ingrese la nota 3:"
Leer n3
Escribir "Ingrese la nota 4:"
Leer n4
Escribir "Ingrese la nota 5:"
Leer n5

promedio <- (n1 + n2 + n3 + n4 + n5) / 5

Escribir "El promedio es: ", promedio

Si promedio >= 61 Entonces
	Escribir "APROBADO"
Sino
	Escribir "REPROBADO"
FinSi
FinAlgoritmo
?? Explicación rápida:
	Pide 5 notas
	Calcula el promedio
	Si el promedio es 61 o más ? aprueba
		Si es menor ? reprueba
		
		Si quieres, puedo hacerlo con validación (que no ingresen notas mayores a 100 o menores a 0) ??