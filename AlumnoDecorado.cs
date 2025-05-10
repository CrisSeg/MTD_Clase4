﻿using System;

namespace Clase_4
{
	public abstract class AlumnoDecorado: IAlumno
	{
		private IAlumno decorado;
		
		public AlumnoDecorado(IAlumno d){
			this.decorado = d;
		}
		
		//Implemento la interface IAlumno
		public string getNombre(){
			return this.decorado.getNombre();
		}
		
		public int getDni(){
			return this.decorado.getDni();
		}
		
		public int getLegajo(){
			return this.decorado.getLegajo();
		}
		
		public int getPromedio(){
			return this.decorado.getPromedio();
		}
		
		public void setCalificacion(int c){
			this.decorado.setCalificacion(c);
		}
		
		public int getCalificacion(){
			return this.decorado.getCalificacion();
		}
		
		public void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.decorado.setNvaEstrategia(nvaEstrategia);
		}
		
		public void prestandoAtencion(){
			this.decorado.prestandoAtencion();
		}
		
		public void distraerse(){
			this.decorado.distraerse();
		}
		
		public void actualizar(Observado o){
			this.decorado.actualizar(o);
		}
		
		public int responderPregunta(int pregunta){
			return this.decorado.responderPregunta(pregunta);
		}
		
		public virtual string mostrarCalificacion(){
			return this.decorado.mostrarCalificacion();
		}
		
		public string toString()
		{
			return this.decorado.toString();
		}
		
		public bool sosIgual(Comparable c)
        {
			return this.decorado.sosIgual((IAlumno)c);
        }

        public bool sosMenor(Comparable c)
        {
            return this.decorado.sosMenor((IAlumno)c);
        }

        public bool sosMayor(Comparable c)
        {
        	return this.decorado.sosMayor((IAlumno)c);
        }
	}
}
