using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace debugging
{


public class Program
	{
		public static void Main()
        {

	IDictionary<int, string> numberNames = new Dictionary<int, string>();
	numberNames.Add(1,"One"); //adding key/value using the Add() method
			numberNames.Add(3, "Three");
		numberNames.Add(2,"Two");
		
		foreach(KeyValuePair<int, string> kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

			//creating a dictionary using collection-initializer syntax
			var cities = new Dictionary<string, string>()
			{
			{"UK","London, Manchester, Birmingham"},
			{"CH","Chicago, New York, Washington"},
			{"MU","Mumbai, New Delhi, Pune"}
			};
		
		foreach(var kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		}
	}
}
