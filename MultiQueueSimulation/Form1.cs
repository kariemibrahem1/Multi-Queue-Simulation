using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {

		public Form1()
        {
            InitializeComponent();
        }
        SimulationSystem simulationSystem = new SimulationSystem();
		private string fileName;

		private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
			if (simulationSystem.Servers.Count ==0)
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                try
                {
					
                    richTextBox1.Clear();
                    string filePath = openFileDialog.FileName;
					fileName = openFileDialog.SafeFileName;
					string fileContents = File.ReadAllText(filePath);
                    string[] TextLines = fileContents.Split('\n');
                    richTextBox1.Text = fileContents;
					simulationSystem.StartProgram(TextLines);
					loadComboBoxData();
                    DisplayDataFromTestCase();

				}
				catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }

               
                
            }
			}
			else
			{
				simulationSystem = new SimulationSystem();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        richTextBox1.Clear();
                        string filePath = openFileDialog.FileName;
                        fileName = openFileDialog.SafeFileName;
                        string fileContents = File.ReadAllText(filePath);
                        string[] TextLines = fileContents.Split('\n');
                        richTextBox1.Text = fileContents;
                        simulationSystem.StartProgram(TextLines);
                        loadComboBoxData();
                        DisplayDataFromTestCase();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reading the file: " + ex.Message);
                    }



                }
            }
        }

		public void loadComboBoxData()
		{
			serverComboBox.Items.Clear();
			for (int i = 1; i <= simulationSystem.NumberOfServers; i++)
			{
				serverComboBox.Items.Add(i);
			}
		}

		public void DisplayDataFromTestCase()
		{

			stoppingCriteriaTextBox.Text = simulationSystem.StoppingCriteria.ToString();
			selectionMethodTextBox.Text = simulationSystem.SelectionMethod.ToString();
			numberOfServersTextBox.Text = simulationSystem.NumberOfServers.ToString();
			stoppingNumberTextBox.Text = simulationSystem.StoppingNumber.ToString();
		}
        

		private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void simulateButton_Click(object sender, EventArgs e)
		{
			if (simulationSystem != null)
			{

				simulationSystem.CreateTableWithFields();
				simulationSystem.calculateServersPerformanceMeasures();

				simulationSystem.calculateSystemPerformanceMeasures();
				simulationSystem.clearSimulation();

				TableOfData tableOfData = new TableOfData(simulationSystem);
				tableOfData.Show();

                string result = TestingManager.Test(simulationSystem, fileName);
                MessageBox.Show(result);
            }
			else
				MessageBox.Show("Please Choose Test Case");
		}

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = serverComboBox.SelectedIndex;
            serviceTimeDistributionDataTable.Rows.Clear();


            for (int i = 0; i < simulationSystem.Servers[index].TimeDistribution.Count; i++)
            {
                int serviceTime = simulationSystem.Servers[index].TimeDistribution[i].Time;
                decimal Probability = simulationSystem.Servers[index].TimeDistribution[i].Probability;
                decimal CumProp = simulationSystem.Servers[index].TimeDistribution[i].CummProbability;
                int MinRange = simulationSystem.Servers[index].TimeDistribution[i].MinRange;
                int MaxRange = simulationSystem.Servers[index].TimeDistribution[i].MaxRange;

                serviceTimeDistributionDataTable.Rows.Add(serviceTime, Probability, CumProp, MinRange, MaxRange);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serviceTimeDistributionDataTable.Rows.Clear();
            for (int i = 0; i < simulationSystem.InterarrivalDistribution.Count; i++)
            {
                int serviceTime = simulationSystem.InterarrivalDistribution[i].Time;
                decimal Probability = simulationSystem.InterarrivalDistribution[i].Probability;
                decimal CumProp = simulationSystem.InterarrivalDistribution[i].CummProbability;
                int MinRange = simulationSystem.InterarrivalDistribution[i].MinRange;
                int MaxRange = simulationSystem.InterarrivalDistribution[i].MaxRange;

                serviceTimeDistributionDataTable.Rows.Add(serviceTime, Probability, CumProp, MinRange, MaxRange);
            }
        }

        private void serviceTimeDistributionDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
