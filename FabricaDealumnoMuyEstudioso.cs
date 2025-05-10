using System;

namespace Clase_4
{
	public class FabricaDealumnoMuyEstudioso: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(gen.stringAleatorio(5), gen.numeroAleatorio(1000000), gen.numeroAleatorio(1000), gen.numeroAleatorio(10));
		}
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}
	}
}
