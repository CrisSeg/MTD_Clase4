﻿using System;

namespace Clase_4
{
	//Ejercicio 1
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(IAlumno a1, IAlumno a2);
		bool sosMenor(IAlumno a1, IAlumno a2);
 		bool sosMayor(IAlumno a1, IAlumno a2);
	}
}
