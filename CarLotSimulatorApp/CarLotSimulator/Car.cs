using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{

		}

		public Car(int year, string make, string model)
		{

		}
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }

		public void MakeEngineNoise(string noise)
		{
			Console.WriteLine($"The {Make}'s engine goes like {noise}");
		}
	}
}

