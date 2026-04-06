Algoritmo sin_titulo
	definir a, b, c Como Entero
	escribir" TRIANGULO EQULATERO, ESCALENO O ISOCELES"
	Escribir "angulo 1: "
	leer a
	escribir "angulo 2: "
	leer b
	escribir "angulo 3: "
	leer c
	si a+b+c= 180 Entonces
		si a=b y b = c Entonces
			escribir " ES UN TRIANGULO EQULATERO"
		SiNo
			
			si a= b o a= c o b= c Entonces
				Escribir " ES UN TRIANGULO ISOCELES"
			SiNo
				escribir " ES UN TRIANGULO ESCALENO"
			FinSi
		FinSi
	Sino 
		Escribir " EL TRIANGUO NO ES VALIDO"
	FinSi
	
FinAlgoritmo
