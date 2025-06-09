using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_4
{
	public class GenerarDatosAleatorios
	{
		private static Random rn = new Random();

		public int numeroAleatorio(int max){
			int num = rn.Next(0, max);
			return num;
		}
		
		public string stringAleatorio(int cantidad){
			const string letras = "abcdefghijklmnopqrstuvwyz";
			StringBuilder palabra = new StringBuilder();
			
			for (int i = 0; i < cantidad; i++) {
				palabra.Append(letras[rn.Next(0, letras.Length)]);
			}
			
			return palabra.ToString();
		}
	}
}
