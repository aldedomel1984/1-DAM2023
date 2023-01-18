using System;
public class ejercicio4431
{
 public static void Main()
 {	
        Console.WriteLine("introduce una palabra");
	string clave = Console.ReadLine();
	int longitud=clave.Length;
	char[] letras= new char[longitud];
	for(int x=0;x<=clave.Length;x++)
	{
		Console.WriteLine("introduce un caracter");
		string nombre = Console.ReadLine();
		letras[x] = nombre[0];
		Console.WriteLine(letras[x]);
	}
	for(int x=0;x<clave.Length;x++)
	{
		Console.Write(letras[x]);
	}
	
 }
}