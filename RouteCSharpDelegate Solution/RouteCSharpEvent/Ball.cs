using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEvent
{
    internal class Ball
    {
        public int Id { get; set; }
		private Location ballLocation;

		public Location BallLocation
        {
			get => ballLocation; 
			set 
			{
				if(ballLocation != value) // Ball Moved To Another Location
				{
                    ballLocation = value;
					BallLocationChanged?.Invoke(); // Fire Event
                }
			}
		}

		public event Action BallLocationChanged;
	}
}
