using System;
using System.Collections.Generic;

namespace Clase_4
{
	public abstract class FabricaDeComparables
	{
		protected GenerarDatosAleatorios gen = new GenerarDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			
			switch (opcion) {
					case 1: fabrica = new FabricaDeAlumnos(); break;
					case 2: fabrica = new FabricaDeNumeros(); break;
					case 3: fabrica = new FabricaDeProfesores(); break; 
					case 4: fabrica = new FabricaDealumnoMuyEstudioso(); break;
					case 5: fabrica = new FabricaDeAlumnoDecorado(); break;
					case 6: fabrica = new FabricaDeAlumnoMuyEstudiosoDec(); break;
			}
			
			return fabrica.crearAleatorio();
		}
	
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			
			switch (opcion) {
					case 1: fabrica = new FabricaDeAlumnos(); break;
					case 2: fabrica = new FabricaDeNumeros(); break;
					case 3: fabrica =new FabricaDeProfesores(); break; 
					case 4: fabrica = new FabricaDealumnoMuyEstudioso(); break;
					case 5: fabrica = new FabricaDeAlumnoDecorado(); break;
					case 6: fabrica = new FabricaDeAlumnoMuyEstudiosoDec(); break;
			}
			
			return fabrica.crearPorTeclado();
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
	}
}
