using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
		public SimulationSystem()
		{
			this.Servers = new List<Server>();
			this.InterarrivalDistribution = new List<TimeDistribution>();
			this.PerformanceMeasures = new PerformanceMeasures();
			this.SimulationTable = new List<SimulationCase>();
			this.StoppingCriteria = new Enums.StoppingCriteria();
			this.SelectionMethod = new Enums.SelectionMethod();
		}

		///////////// INPUTS ///////////// 
		public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }


		public List<SimulationCase> v = new List<SimulationCase>();
		public int max = -1;
        public int NumberOfCustomer = 0;


		private int Simulation_runTime;
		private int total_time_waited;
		private int number_of_customers_waited;

		///////////// OUTPUTS /////////////
		public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        public List<TimeDistribution> CalcTableTimeDistripution(List<TimeDistribution> table)
        {
            decimal cummulativeProbability = 0;
            int minRange = 1;

            foreach (TimeDistribution item in table)
            {
                cummulativeProbability += item.Probability;
                item.CummProbability = cummulativeProbability;
                item.MinRange = minRange;
                item.MaxRange = (int)(cummulativeProbability * 100);
                minRange = item.MaxRange + 1;
            }
            return table;

        }
        public void StartProgram(string[] TextLines)
        {
            NumberOfServers = Convert.ToInt32(TextLines[1]);
            for (int i = 1; i <= NumberOfServers; i++)
            {
                Server server = new Server()
                {
                    ID = i,
                };
                Servers.Add(server);
            }
            StoppingNumber = Convert.ToInt32(TextLines[4]);
            StoppingCriteria = (Enums.StoppingCriteria)Convert.ToInt32(TextLines[7]);
            SelectionMethod = (Enums.SelectionMethod)Convert.ToInt32(TextLines[10]);
            int currentLine = 13;
            while (TextLines[currentLine] != "\r")
            {
                string[] separator = { ", " };
                string[] values = TextLines[currentLine].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                TimeDistribution timeDistribution = new TimeDistribution();
                timeDistribution.Time = Convert.ToInt32(values[0]);
                timeDistribution.Probability = Convert.ToDecimal(values[1]);
                InterarrivalDistribution.Add(timeDistribution);
                currentLine++;
            }


            for (int j = 0; j < NumberOfServers; j++)
            {
                currentLine += 2;
                while (currentLine < TextLines.Length && TextLines[currentLine] != "\r")
                {
                    string[] separator = { ", " };
                    string[] values = TextLines[currentLine].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                    TimeDistribution timeDistribution = new TimeDistribution();
                    timeDistribution.Time = Convert.ToInt32(values[0]);
                    timeDistribution.Probability = Convert.ToDecimal(values[1]);
                    Servers[j].TimeDistribution.Add(timeDistribution);
                    currentLine++;
                }
            }
            InterarrivalDistribution = CalcTableTimeDistripution(InterarrivalDistribution);
            for (int i = 0; i < this.NumberOfServers; i++)
            {
                Servers[i].TimeDistribution = CalcTableTimeDistripution(Servers[i].TimeDistribution);
            }
            
        }

        public void CreateTableWithFields()
		{
            var random = new Random();
            for (int i = 0; i < StoppingNumber; i++)
            {
                SimulationCase customerCase = new SimulationCase();
                customerCase.CustomerNumber = i + 1;

                if (i == 0)
                {
                    customerCase.RandomInterArrival = 1;
                    customerCase.InterArrival = 0;
                    customerCase.ArrivalTime = 0;
                }
                else
                {
                    customerCase.RandomInterArrival = random.Next(1, 100);
                    customerCase.InterArrival = calculateInterArrival(customerCase);
                    customerCase.ArrivalTime = SimulationTable[i - 1].ArrivalTime + customerCase.InterArrival;
                }

                customerCase.RandomService = random.Next(1, 100);
                customerCase.ServiceTime = calculateServiceTime(customerCase);

                int assignedServerIndex = assignServer(customerCase.ArrivalTime);
                Server assignedServer = Servers[assignedServerIndex];

                customerCase.AssignedServer = assignedServer;
                customerCase.StartTime = Math.Max(customerCase.ArrivalTime, assignedServer.FinishTime);
                customerCase.TimeInQueue = customerCase.StartTime - customerCase.ArrivalTime;
                total_time_waited += customerCase.TimeInQueue;

                customerCase.EndTime = customerCase.StartTime + customerCase.ServiceTime;
                assignedServer.FinishTime = customerCase.EndTime;
                assignedServer.TotalWorkingTime += customerCase.ServiceTime;
                assignedServer.customers++;
                assignedServer.Intervals.Add(new KeyValuePair<int, int>(customerCase.StartTime, customerCase.EndTime));

                Simulation_runTime = Math.Max(Simulation_runTime, customerCase.EndTime);
                SimulationTable.Add(customerCase);
            }

        }
        public int calculateInterArrival(SimulationCase customerCase)
        {

            for (int i = 0; i < InterarrivalDistribution.Count; i++)
            {
                if (customerCase.RandomInterArrival <= InterarrivalDistribution[i].MaxRange &&
                    customerCase.RandomInterArrival >= InterarrivalDistribution[i].MinRange)
                {
                    return InterarrivalDistribution[i].Time;

                }
            }
            return 0;
        }
        public int assignServer(int arrivalTime)
        {
            if (SelectionMethod.Equals(Enums.SelectionMethod.HighestPriority))
            {
                return AssignHighestPriority(arrivalTime);
            }
            else if (SelectionMethod.Equals(Enums.SelectionMethod.Random))
            {
                return AssignRandom(arrivalTime);
            }
            else
            {
                return AssignLeastUtilization(arrivalTime);
            }
        }
        private int AssignHighestPriority(int arrivalTime)
        {
            int availableServerIndex = -1;
            int earliestFinishTime = int.MaxValue;

            for (int i = 0; i < Servers.Count; i++)
            {
                if (arrivalTime >= Servers[i].FinishTime)
                {
                    return i;
                }

                if (Servers[i].FinishTime < earliestFinishTime)
                {
                    earliestFinishTime = Servers[i].FinishTime;
                    availableServerIndex = i;
                }
            }

            number_of_customers_waited++;
            return availableServerIndex;
        }
        private int AssignRandom(int arrivalTime)
        {
            List<int> idleServers = Servers
                .Select((server, index) => new { Server = server, Index = index })
                .Where(x => arrivalTime >= x.Server.FinishTime)
                .Select(x => x.Index)
                .ToList();

            if (idleServers.Count > 0)
            {
                int randomIndex = new Random().Next(idleServers.Count);
                return idleServers[randomIndex];
            }

            return -1;
        }
        private int AssignLeastUtilization(int arrivalTime)
        {
            return 0;
        }
        public int calculateServiceTime(SimulationCase customerCase)
        {

            for (int i = 0; i < customerCase.AssignedServer.TimeDistribution.Count; i++)
            {
                if (customerCase.RandomService <= customerCase.AssignedServer.TimeDistribution[i].MaxRange &&
                    customerCase.RandomService >= customerCase.AssignedServer.TimeDistribution[i].MinRange)
                    return customerCase.AssignedServer.TimeDistribution[i].Time;
            }
            return 0;
        }

        public void calculateSystemPerformanceMeasures()
        {
            PerformanceMeasures.AverageWaitingTime = (decimal)total_time_waited / (decimal)StoppingNumber;
            PerformanceMeasures.WaitingProbability = (decimal)number_of_customers_waited / (decimal)StoppingNumber;
            PerformanceMeasures.MaxQueueLength = calculateMaximumQueueLength();

        }
        public void clearSimulation()
        {
            foreach (var customerCase in SimulationTable)
            {
                customerCase.AssignedServer.FinishTime = 0;
            }
        }

        public int calculateMaximumQueueLength()
        {
            if (number_of_customers_waited == 0)
            {
                return 0;
            }
            else
            {
                int maximumQueueLength = SimulationTable
                    .Select((item, index) => SimulationTable
                        .Skip(index)
                        .Count(x => item.StartTime > x.ArrivalTime))
                    .Max();

                return maximumQueueLength;
            }
        }
		public void calculateServersPerformanceMeasures()
		{
			foreach (var server in Servers)
			{
				server.CalculateAverageServiceTime();
				server.CalculateIdleProbability(Simulation_runTime);
				server.CalculateUtilization(Simulation_runTime);
			}
		}
		public int getSimulationTime()
		{
			return Simulation_runTime;
		}
	}
}
