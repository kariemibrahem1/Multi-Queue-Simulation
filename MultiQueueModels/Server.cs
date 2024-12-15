using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {

		public Server()
		{
			this.TimeDistribution = new List<TimeDistribution>();
			this.Intervals = new List<KeyValuePair<int, int>>();
		}

		public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
		public List<KeyValuePair<int, int>> Intervals;
        public int customers { get; set; }

		public void CalculateAverageServiceTime()
		{
			if (customers != 0)
				AverageServiceTime = (decimal)TotalWorkingTime / (decimal)customers;
		}

		public void CalculateIdleProbability(int totalSimulationTime)
		{
			int totalIdleTime = totalSimulationTime - TotalWorkingTime;
			IdleProbability = (decimal)totalIdleTime / (decimal)totalSimulationTime;
		}

		public decimal CalculateUtilization(int totalSimulationTime)
		{
			if (totalSimulationTime != 0)
				return Utilization = (decimal)TotalWorkingTime / (decimal)totalSimulationTime;
			else
				return 0;
		}

	}
}
