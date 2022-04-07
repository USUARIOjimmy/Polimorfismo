
using System;

namespace ejercicio1SobrecargaOperadores{
	class Program{
		public static void Main(string[] args){
			
			
			Vector v1=new Vector();
			Vector v2=new Vector();
			//a) ++ para mostrar datos
			Console.WriteLine("----- inciso a -----");
			//v1++;
			v2++;
			//b) -- para leer datos
			Console.WriteLine("----- inciso b -----");
			v2--;
			//v1--;
			//c) + para incrementar los datos en k unidades
			Console.WriteLine("----- inciso c -----");
			
			Console.Write("ingrese k: ");
			int k = int.Parse(Console.ReadLine());
			v2 = v2 + k;
			v2++;
			//v1 = v1 + k;
			//v1++;
			//d) * dados dos objetos vector mostrar los datos de aquel que tiene mas elementos
			Console.WriteLine("----- inciso d -----");
			//v1 = v1 > v2; //error el metodo > es bool (v1 = v1 > v2 si funciona si es  Vector )
			bool sw=v1*v2;
			if(sw){
				Console.WriteLine("mayor es:");
				v1++;
			}
			else{
				Console.WriteLine("mayor es:");
				v2++;
			}
			//e) % para determinar cuantas veces se repite el dato k
			Console.WriteLine("----- inciso d -----");
			Console.Write("ingrese k: ");
			int k2 = int.Parse(Console.ReadLine());
			int salida=v1 % k2;
			Console.WriteLine("se repite: "+salida);
			//int salida2=v2 % k2;
			//Console.WriteLine("se repite: "+salida2);
			
			/*
			----- inciso a -----
			n: 3
			23
			45
			45
			----- inciso b -----
			ingrese n: 1
			ingrese vn: 22
			----- inciso c -----
			ingrese k: 1
			n: 1
			23
			----- inciso d -----
			mayor es:
			n: 3
			23
			45
			45
			----- inciso d -----
			ingrese k: 45
			se repite: 2
			 */

			
			Console.ReadKey(true);
		}
	}
}