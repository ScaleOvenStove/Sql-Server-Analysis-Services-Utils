using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.AnalysisServices.AdomdClient;
using Microsoft.AnalysisServices;
using Microsoft.SqlServer.MessageBox;

namespace SSASUtils.ObjectProcessor
{
    public partial class Main : Form
    {

        private Microsoft.AnalysisServices.Server _server;
        private Microsoft.AnalysisServices.Database _database;
        private Microsoft.AnalysisServices.Cube _cube;

        public Main()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (null != _server)
                {
                    _server.Disconnect();
                }
                else
                {
                    _server = new Server();
                }

                _server.Connect(txtServerName.Text);
                EnableControls();
                PopulateDBDropDown();
            }
            catch (AmoException exception)
            {
                ExceptionMessageBox emb = new ExceptionMessageBox(exception);
                emb.Show(this);
                DisableControls();
            }
        }

        private void PopulateDBDropDown()
        {
            cbDatabase.Items.Clear();
            foreach (Database d in _server.Databases)
            {
                cbDatabase.Items.Add(d.Name);
            }

        }

        private void PopulateCubeDropDown()
        {
            cbCube.Items.Clear();
            foreach (Cube c in _database.Cubes)
            {
                cbCube.Items.Add(c.Name);
            }
        }

        private void EnableControls()
        {
            cbCube.Enabled = true;
            cbDatabase.Enabled = true;
        }

        private void DisableControls()
        {
            cbCube.Enabled = false;
            cbDatabase.Enabled = false;
        }

        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            _database = _server.Databases.GetByName(cbDatabase.SelectedItem.ToString());
            PopulateCubeDropDown();
        }

        private void cbCube_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cube = _database.Cubes.GetByName(cbCube.SelectedItem.ToString());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DisableControls();
            //btnConnect_Click(sender, e);

        }

        private void btnGetDimensions_Click(object sender, EventArgs e)
        {
            clbDimensions.Items.Clear();

            foreach(Microsoft.AnalysisServices.Dimension dimension in _database.Dimensions)
            {
                clbDimensions.Items.Add(dimension.Name);
            }
        }

        private void btnProcessDimensions_Click(object sender, EventArgs e)
        {
            // set the server to capture XML, it wont actually execute anything
            _server.CaptureXml = true;

            // loop through checked dim's and sent off xml to server to process
            foreach (int i in clbDimensions.CheckedIndices)
            {
                
                Microsoft.AnalysisServices.Dimension dimension = 
                    _database.Dimensions.GetByName(clbDimensions.Items[i].ToString());

                dimension.Process(Microsoft.AnalysisServices.ProcessType.ProcessFull);

            }

            // stop capturing xml
            _server.CaptureXml = false;

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());

            XmlaResultCollection xmlaResults = _server.ExecuteCaptureLog(true, true);

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());

            // log any errors/warnings
            foreach (XmlaResult xmlaResult in xmlaResults)
            {
                foreach (XmlaMessage xmlaMessage in xmlaResult.Messages)
                {
                    if (xmlaMessage.GetType().Name == "XmlaError")
                    {
                        // error
                        MessageBox.Show(xmlaMessage.Description);
                    }
                    else
                    {
                        // warning
                        MessageBox.Show(xmlaMessage.Description);
                    }
                }

            }
        }

        private void btnGetPartitions_Click(object sender, EventArgs e)
        {
            clbPartitions.Items.Clear();

            if (_cube != null)
            {
                foreach (MeasureGroup measureGroup in _cube.MeasureGroups)
                {
                    foreach (Partition partition in measureGroup.Partitions)
                    {
                        if (!string.IsNullOrEmpty(txtPartitionNameFilter.Text))
                        {
                            if (partition.Name.Contains(txtPartitionNameFilter.Text))
                            {
                                clbPartitions.Items.Add(measureGroup.Name + " * " + partition.Name);
                            }
                        }
                        else
                        {
                            clbPartitions.Items.Add(measureGroup.Name + " * " + partition.Name);
                        }
                        
                    }
                }
            }
            else
            {
                foreach (Cube cube in _database.Cubes)
                {
                    foreach (MeasureGroup measureGroup in cube.MeasureGroups)
                    {
                        foreach (Partition partition in measureGroup.Partitions)
                        {
                            if (!string.IsNullOrEmpty(txtPartitionNameFilter.Text))
                            {
                                if (partition.Name.Contains(txtPartitionNameFilter.Text))
                                {
                                    clbPartitions.Items.Add(measureGroup.Name + " * " + partition.Name);
                                }
                            }
                            else
                            {
                                clbPartitions.Items.Add(measureGroup.Name + " * " + partition.Name);
                            }
                        }
                    }
                }
            }
        }

        private void btnProcessPartitions_Click(object sender, EventArgs e)
        {
            // set the server to capture XML, it wont actually execute anything
            _server.CaptureXml = true;

            // loop through checked partitions's and sent off xml to server to process
            foreach (int i in clbPartitions.CheckedIndices)
            {
                string checkedItem = clbPartitions.Items[i].ToString();
                string measureGroupName = checkedItem.Substring(0, checkedItem.IndexOf("*")).Trim();
                string partitionName = checkedItem.Replace(measureGroupName + " * ", "");

                MeasureGroup measureGroup = _cube.MeasureGroups.GetByName(measureGroupName);

                Partition partition = _cube.MeasureGroups[measureGroup.ID].Partitions.GetByName(partitionName);

                partition.Process(Microsoft.AnalysisServices.ProcessType.ProcessFull);
            }

            // stop capturing xml
            _server.CaptureXml = false;

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());

            XmlaResultCollection xmlaResults = _server.ExecuteCaptureLog(true, true);

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());

            // log any errors/warnings
            foreach (XmlaResult xmlaResult in xmlaResults)
            {
                foreach (XmlaMessage xmlaMessage in xmlaResult.Messages)
                {
                    if (xmlaMessage.GetType().Name == "XmlaError")
                    {
                        // error
                        MessageBox.Show(xmlaMessage.Description);
                    }
                    else
                    {
                        // warning
                        MessageBox.Show(xmlaMessage.Description);
                    }
                }

            }
        }
    }
}