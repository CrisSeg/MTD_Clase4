using System;
using System.Collections.Generic;
using MetodologíasDeProgramacionI;

namespace Clase_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Teacher teacher = new Teacher();
			Student stu;
			Comparable c;
			
			for (int i = 0; i < 20; i++) {
				if (i < 10) {
					c = FabricaDeComparables.crearAleatorio(5);
					stu = new AlumnoAdapter((IAlumno)c);
				}
				else{
					c = FabricaDeComparables.crearAleatorio(6);
					stu = new AlumnoAdapter((IAlumno)c);
				}
				teacher.goToClass(stu);
			}
			
			teacher.teachingAClass();
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
			public static void llenar(Coleccionable c){
			Random rn = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable com = new Numero(rn.Next());
				c.agregar(com);
			}
		}
		
		//Clase 2 Ejercicio 6
		public static void imprimirElementos(Coleccionable col){
			Iterador ite = col.crearIterador();
			
			ite.primero();
			while (!ite.fin()) {
				Console.WriteLine(ite.actual().toString());
				ite.siguiente();
			}
		}
		
		//Clase 2 Ejercicio 8
		public static void cambiarEstrategia(Coleccionable col, EstrategiaDeComparacion est){
			Iterador ite = col.crearIterador();
			
			ite.primero();
			while (!ite.fin()) {
				((Alumno)ite.actual()).setNvaEstrategia(est);
				ite.siguiente();
			}
		}
		
		//Clase 3 Ejercicio 6
		public static void llenar(Coleccionable col, int op){
			for (int i = 0; i < 20; i++) {
				Comparable c = FabricaDeComparables.crearAleatorio(op);
				col.agregar(c);
			}
		}
		
		public static void informar(Coleccionable col, int op){
			Console.WriteLine(col.cuantos());
			Console.WriteLine(col.minimo().toString());
			Console.WriteLine(col.maximo().toString());
			
			Comparable c = FabricaDeComparables.crearPorTeclado(op);
			if (col.contiene(c)) {
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else
				Console.WriteLine("El elemento leido no esta en la coleccion");
		}
		
		public static void dictadoDeClases(Profesor p){
			for (int i = 0; i < 5; i++) {
				p.hablarALaClase();
				p.escribirEnElPizarron();
			}
		}
	}
}