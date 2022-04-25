using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author $Deepak C.R
 *  Retrieve all the Keys and Values using Dictionary and Hashtable.
 */

namespace Concepts
{ 
	public class Dihash
	{
		//Using static method for demonstrating Hashtable
		public static void hash()
        {
			//Creating reference variable for Hashtable
			Hashtable hash1 = new Hashtable();
			//Adding key value pairs for HashTable
			hash1.Add(1 , "Music");
			hash1.Add("genre", "Hip-Hop,Classical,Pop,Rock,EDM" );
			hash1.Add(2, "Dance");
			hash1.Add("Styles", "Hip-Hop, Break dance, Contemporary,BharathaNatyam,Freestyle");
			hash1.Add(3, "Painting");
			hash1.Add("Art Form", "Abstract paintiing, Glass painting, Water painting");

			Console.WriteLine("\t\t\t\t\t*******List of Arts*******\n");
			//DictionaryEntry is used to retrive the key value pairs of hash table
			foreach (DictionaryEntry de in hash1)

				//Printing key value pairs
				Console.WriteLine("\t\t\tArt: {0},     Styles: {1}", de.Key, de.Value);
		}

		public static void DictionaryMethod()
        {
			Dictionary<string, string> di = new Dictionary<string, string>();
			di.Add(".mp3", "Music");
			di.Add(".mov", "Videos");
			di.Add(".jpeg", "Photos");

			Console.WriteLine("\t\t\t\t   *******List of Formats*******\n");

			foreach (var content in di)
				Console.WriteLine("\t\t\t\t     Format: {0}, Type: {1}", content.Key, content.Value);


		}
		public static void Main()
		{
			Console.WriteLine("\t\t\t*********************HASH_TABLES*********************");
			Console.WriteLine();
			hash();
			Console.WriteLine("\n\n\t\t\t*********************DICTIONARY*********************");
			Console.WriteLine();
			DictionaryMethod();

		}
	}
}

