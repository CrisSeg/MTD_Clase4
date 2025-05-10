using System;

namespace Clase_4
{
	public interface IAlumno: Comparable
	{
		string getNombre();
		int getDni();
		int getLegajo();
		int getPromedio();
		void setCalificacion(int c);
		int getCalificacion();
		void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia);
		
		void prestandoAtencion();
		void distraerse();
		void actualizar(Observado o);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
