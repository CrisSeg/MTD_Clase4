/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 8/5/2025
 * Hora: 00:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase_4
{
	/// <summary>
	/// Description of FabricaDeAlumnoDecorado.
	/// </summary>
	public class FabricaDeAlumnoDecorado: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			IAlumno a = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			IAlumno d = new AlumnoDecoradoLegajoDec(a);
			d = new AlumonDecoradoNL(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoAsterisco(d);
			
			return d;
		}
		
		public override Comparable crearPorTeclado(){
			IAlumno a = (IAlumno)FabricaDeComparables.crearPorTeclado(1);
			IAlumno d = new AlumnoDecoradoLegajoDec(a);
			d = new AlumonDecoradoNL(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoPAD(d);
			d = new AlumnoDecoradoAsterisco(d);
			
			return d;
		}
	}
}
