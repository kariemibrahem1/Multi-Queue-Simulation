using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MultiQueueSimulation
{

	public partial class TableOfData : Form
	{
		private SimulationSystem simulationSystem;
		public TableOfData(SimulationSystem simulationSystem)
		{
			InitializeComponent();
			this.simulationSystem = simulationSystem;
		}

	

		public void loadComboBoxData()
		{
			serverComboBox.Items.Clear();
			for (int i = 1; i <= simulationSystem.NumberOfServers; i++)
			{
				serverComboBox.Items.Add(i);
			}
		}

		private void populateDataView()
		{

            foreach (var simulationCase in simulationSystem.SimulationTable)
			{
				int customerNumber = simulationCase.CustomerNumber;
				int interArrivalRandom = simulationCase.RandomInterArrival;
				int interArrivalTime = simulationCase.InterArrival;
				int arrivalTime = simulationCase.ArrivalTime;
				int serviceRandom = simulationCase.RandomService;
				int starttime = simulationCase.StartTime;
				int servicetime = simulationCase.ServiceTime;
				int endtime = simulationCase.EndTime;
				int idofserver = simulationCase.AssignedServer.ID;
				int TimeInQueue=simulationCase.TimeInQueue;
				

				outputDataGridView.Rows.Add(customerNumber, interArrivalRandom, interArrivalTime, arrivalTime,
					serviceRandom,starttime,servicetime,endtime,idofserver,TimeInQueue);

			}
			DisplayDataPerformance();

        }

		private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void busyTimeButton_Click(object sender, EventArgs e)
		{

		}

		private void outputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void TableOfData_Load(object sender, EventArgs e)
		{
			populateDataView();
			loadComboBoxData();
		}

		private void averageWaitingTextBox_TextChanged(object sender, EventArgs e)
		{

		}
        public void DisplayDataPerformance()
		{		
			averageWaitingTextBox.Text = simulationSystem.PerformanceMeasures.AverageWaitingTime.ToString();
			probabilityOfWaitTextBox.Text = simulationSystem.PerformanceMeasures.WaitingProbability.ToString();
			maxQueueLengthTextBox.Text = simulationSystem.PerformanceMeasures.MaxQueueLength.ToString();
        }
        private void serverComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
			int index = serverComboBox.SelectedIndex;
			idleProbabilityTextBox.Text = simulationSystem.Servers[index].IdleProbability.ToString();
			avgServiceTimeTextBox.Text = simulationSystem.Servers[index].AverageServiceTime.ToString();
			utilizationTextBox.Text = simulationSystem.Servers[index].Utilization.ToString();

		}

		private void busyTimeButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				int index = serverComboBox.SelectedIndex;
				List<KeyValuePair<int, int>> Intervals = simulationSystem.Servers[index].Intervals;
				int simulationTime = simulationSystem.getSimulationTime();
				Graph serverGraph = new Graph(index, Intervals, simulationTime);
				serverGraph.Show();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Please Choose a server");
			}
		}
	}
}
