using ML_NetRealProblem;

namespace ML.NetRealProblem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Load sample data
			var sampleData = new MachineFailureModel.ModelInput()
			{
				Product_ID = @"L47181",
				Type = @"L",
				Air_temperature = 298.2F,
				Process_temperature = 308.7F,
				Rotational_speed = 1408F,
				Torque = 46.3F,
				Tool_wear = 3F,
			};

			//Load model and predict output
			var result = MachineFailureModel.Predict(sampleData);
		}
	}
}
