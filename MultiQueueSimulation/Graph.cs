using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
	public partial class Graph : Form
	{

		private int serverIndex;
		private List<KeyValuePair<int, int>> Intervals;
		private int simulationTime;

		public Graph(int serverIndex, List<KeyValuePair<int, int>> Intervals, int simulationTime)
		{
			InitializeComponent();
			this.serverIndex = serverIndex;
			this.Intervals = Intervals;
			this.simulationTime = simulationTime;

		}
		private void Graph_Load(object sender, EventArgs e)
		{
			chart1.Series[0].Name = "Busy Time";
			chart1.ChartAreas[0].AxisY.Minimum = 0;
			chart1.ChartAreas[0].AxisY.Maximum = 1;
			chart1.ChartAreas[0].AxisX.Minimum = 0;
			chart1.ChartAreas[0].AxisX.Title = "Time";
			chart1.ChartAreas[0].AxisY.Title = "Idle / Busy";
			if (simulationTime > 100)
				chart1.ChartAreas[0].AxisX.Interval = 10;
			else
				chart1.ChartAreas[0].AxisX.Interval = 1;

			chart1.Series[0]["PointWidth"] = "1";

			for (int i = 0; i < Intervals.Count; i++)
			{
				int startInterval = Intervals[i].Key,
					endInterval = Intervals[i].Value;
				while (startInterval <= endInterval)
				{
					Console.WriteLine(startInterval);
					chart1.Series[0].Points.AddXY(startInterval, 1);
					startInterval++;
				}
			}
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}
	}
}
