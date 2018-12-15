Algoritmo sin_titulo
	Repetir
		secuencia_de_acciones
	
		//mostrar base
	Limpiar Pantalla
	Escribir "base de recomendaciones"
	Escribir "  1. productos"
	Escribir "  2. facturacion"
	
	Escribir "  4. salir"
	//ingresar opcion
	Escribir "elija una opcion (1-4):"
	Leer OP
	//Procesar esa opcion
	Segun OP Hacer
		1:
			Escribir " + microondas electrodomestico (2500)"
			Escribir "INGRESA CANTIDAD DE PRODUCTO"
			CANTIDAD<-5
			Escribir "precio<"
			precio<-8
			total<-CANTIDAD*precio
		
		2:
			Escribir " + nombre (edson)"
			Escribir " + apellido (lux)"
			Escribir " + pago  (efectivo)"
			Escribir " + nit (35381-4)"
			Escribir CANTIDAD

			Escribir total 
		De Otro Modo:
			Escribir "Gracias vuelva pronto"
	Fin Segun
	Escribir "presione enter para continuar"
	Esperar tecla
	Hasta Que OP=3
FinAlgoritmo

