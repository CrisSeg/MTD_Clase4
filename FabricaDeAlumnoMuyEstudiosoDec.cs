﻿using System;

namespace Clase_4
{
	public class FabricaDeAlumnoMuyEstudiosoDec: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			IAlumno a = (IAlumno)FabricaDeComparables.crearAleatorio(4);
			IAlumno d = new AlumnoDecoradoLegajoDec(a);
			d = new AlumonDecoradoNL(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoAsterisco(d);
			
			return d;
		}
		
		public override Comparable crearPorTeclado(){
			IAlumno a = (IAlumno)FabricaDeComparables.crearPorTeclado(4);
			IAlumno d = new AlumnoDecoradoLegajoDec(a);
			d = new AlumonDecoradoNL(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoAsterisco(d);
			
			return d;
		}
	}
}
