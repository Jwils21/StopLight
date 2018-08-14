using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopLight {
	class Program {
		static void Main(string[] args) {
			(new Program()).run();
		}

		enum TrafficLight{
			Red, Green, Yellow
		};

		void DisplayTrafficLight(TrafficLight color) {
			switch (color) {
				case TrafficLight.Red:
					Console.WriteLine("Red");
					break;
				case TrafficLight.Green:
					Console.WriteLine("Green");
					break;
				case TrafficLight.Yellow:
					Console.WriteLine("Yellow");
					break;
			}
		}

		void run() {
			for(int idx = 0;idx < 3;idx++) {
				TrafficLight colorIdx = TrafficLight.Red; //red
				DisplayTrafficLight(colorIdx);
				DisplayTrafficLight(++colorIdx);
				DisplayTrafficLight(++colorIdx);
			}
		}

		void runAlternate() {
			for(int idx = 0;idx < 3;idx++) {
				int colorIdx = 1;
				TrafficLight color = (TrafficLight)colorIdx;
				DisplayTrafficLight(color);
				color = (TrafficLight)(++colorIdx);
				DisplayTrafficLight(color);
				color = (TrafficLight)(++colorIdx);
				DisplayTrafficLight(color);
				color = (TrafficLight)(++colorIdx);
			}
		}
	}
}
