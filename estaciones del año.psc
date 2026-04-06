Algoritmo sin_titulo
	
		Definir dia, mes Como Entero
		
		Escribir "Ingrese el día:"
		Leer dia
		Escribir "Ingrese el mes (1-12):"
		Leer mes
		
		Si mes = 12 Entonces
			Si dia >= 21 Entonces
				Escribir "Verano"
			Sino
				Escribir "Primavera"
			FinSi
		Sino
			Si mes = 1 O mes = 2 Entonces
				Escribir "Verano"
			Sino
				Si mes = 3 Entonces
					Si dia >= 21 Entonces
						Escribir "Otoño"
					Sino
						Escribir "Verano"
					FinSi
				Sino
					Si mes = 4 O mes = 5 Entonces
						Escribir "Otoño"
					Sino
						Si mes = 6 Entonces
							Si dia >= 21 Entonces
								Escribir "Invierno"
							Sino
								Escribir "Otoño"
							FinSi
						Sino
							Si mes = 7 O mes = 8 Entonces
								Escribir "Invierno"
							Sino
								Si mes = 9 Entonces
									Si dia >= 21 Entonces
										Escribir "Primavera"
									Sino
										Escribir "Invierno"
									FinSi
								Sino
									Si mes = 10 O mes = 11 Entonces
										Escribir "Primavera"
									Sino
										Escribir "Mes no válido"
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
FinAlgoritmo

