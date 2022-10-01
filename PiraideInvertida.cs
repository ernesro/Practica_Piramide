//Pieamide invertida

	using System;
		
		class Ej_obligatiorio{
		
			static void Main(){
				
				int i ,j ; 
				int ancho=0;
				
				Console.WriteLine("Introduce el ancho");
				
				do{
					
					try{
						Console.WriteLine("Tiene que ser un numero mayor o igual a 3 e impar");
						ancho = Convert.ToInt32(Console.ReadLine());
					}
					catch (FormatException){
						Console.Write("No es un numero valido, ");
					}
					
				}while(ancho < 3 || ancho % 2 == 0);
				
				for(i = (ancho/2) + 1 ; i > 0 ; i--){		//Con esto saco la altura de la piramide
					
					for(j=0; j<(ancho/2)+1-i; j++){			//Escribo espacios en funcion de 'i' y la altura maxima
						Console.Write(" ");
					}
					for(j = 1 ; j < i ; j++){
						Console.Write("**");
					}
					Console.WriteLine("*");
				}
			}	
		}		

		
