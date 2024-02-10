using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_OOPSession
{
    internal class Car
    {
		#region Attributes
		private int id;
		private string model;
		private double currentSpead;
		#endregion

		#region Properties
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public double CurrentSpead
		{
			get { return currentSpead; }
			set { currentSpead = value; }
		}
		#endregion

		// If No User Defined Constructor Exist , Compiler Will Always Generate Empty Parameterless Constructor.
		// public Car(){} -> Do Nothing

		//Car() {} // By Compiler
		
		// If U Write User Defined Constructor , compiler Will No Longer Generate Empty Parameterless Constructor.
	
		// User Defined Constructor:

		public Car(int _id , string _model , double _currentSpead)
		{
			id = _id;
			model = _model;
			currentSpead = _currentSpead;
		}

		public Car(int _id , string _model)
		{
			id = _id;
			model = _model;
			currentSpead = 150;
		}

        public Car(string _model , int _id)
        {
            id = _id;
            model = _model;
            currentSpead = 150;
        }
		public Car(int _id) : this(_id , "Jeep" , 120) // Constructor Chaining 
		{

		}

        // Methods
        public override string ToString()
        {
            return $"{id} :: {model} :: {currentSpead}"; // Default : RouteC_OOPSession.Car
        }

    }

	//internal class BMWCar : Car
	//{

	//}
}
