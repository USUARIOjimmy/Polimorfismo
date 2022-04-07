
using System;
namespace ejercicio1SobrecargaOperadores{
	public class Vector{
		//00000000000000 nota 000000000000
		//Sobrecarga de Operadores no hay  this
		//ATRIBUTOS
		private int n;
		private int[] v=new int[50];
		//METODOS
		//CONSTRUCTOR
		public Vector(){
			this.n=3;
			this.v[0]=23;
			this.v[1]=45;
			this.v[2]=45;
			
		}
		//a) ++ para mostrar datos
		public static Vector operator ++(Vector v1){
			Console.WriteLine("n: "+v1.n);
			for(int i=0;i<v1.n;i++){
				Console.WriteLine(v1.v[i]);
			}
			return v1;
		}
		//b) - - para leer datos
		public static Vector operator --(Vector v1){
			Console.Write("ingrese n: ");
			v1.n=int.Parse(Console.ReadLine());
			for(int i=0;i<v1.n;i++){
				Console.Write("ingrese vn: ");
				v1.v[i]=int.Parse(Console.ReadLine());
			}
			return v1;
		}
		//c) + para incrementar los datos en k unidades
		public static Vector operator +(Vector v1 , int k){
			for( int i=0;i<v1.n;i++){
				v1.v[i]=v1.v[i]+k;
				
			}
			return v1;
		}
		//d) < dados dos objetos vector mostrar los datos de aquel que tiene mas elementos
		public static bool operator * (Vector v1, Vector v2){
			if(v1.n > v2.n){
				return true;
			}
			return false;
		}
		//e) % para determinar cuantas veces se repite el dato k
		public static int operator % (Vector v1,int k2){
			int contador=0;
			for(int i=0;i<v1.n;i++){
				if(v1.v[i] == k2){
					contador=contador+1; //constador++;
				}
			}
			return contador;
		}
		

	}
}
