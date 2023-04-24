﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankersAlgorithmGUIProgram
{
    public partial class dataInputForm2 : Form
    {

        public dataInputForm2()
        {
            InitializeComponent();

            //Initializing data structures for the program
            globalDataMembers.maxNeed = new int[globalDataMembers.processesCount][];
            globalDataMembers.currentAllocation = new int[globalDataMembers.processesCount][];
            globalDataMembers.remainingNeed = new int[globalDataMembers.processesCount][];
            globalDataMembers.availableResources = new int[globalDataMembers.resourcesCount];
            globalDataMembers.totalResources = new int[globalDataMembers.resourcesCount];


            //Initializing Maximum Need Grid View
            maxNeedGridView.ColumnCount = globalDataMembers.resourcesCount;
            maxNeedGridView.RowCount = globalDataMembers.processesCount;

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                maxNeedGridView.Columns[i].Name = "Resource " + (i + 1);
            }

            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                maxNeedGridView.Rows[i].HeaderCell.Value = "Process " + (i + 1);
            }

            //Initializing Current Allocation Grid View
            currentAllocationGridView.ColumnCount = globalDataMembers.resourcesCount;
            currentAllocationGridView.RowCount = globalDataMembers.processesCount;

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                currentAllocationGridView.Columns[i].Name = "Resource " + (i + 1);
            }

            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                currentAllocationGridView.Rows[i].HeaderCell.Value = "Process " + (i + 1);
            }

            //Initializing Total Resources Grid View
            totalResourcesGridView.ColumnCount = globalDataMembers.resourcesCount;
            totalResourcesGridView.RowCount = 1;

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                totalResourcesGridView.Columns[i].Name = "Resource " + (i + 1);
            }

            totalResourcesGridView.Rows[0].HeaderCell.Value = "Total Resources";

            //Initializing Available Resources Grid View
            availableResourcesGridView.ColumnCount = globalDataMembers.resourcesCount;
            availableResourcesGridView.RowCount = 1;

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                availableResourcesGridView.Columns[i].Name = "Resource " + (i + 1);
            }

            availableResourcesGridView.Rows[0].HeaderCell.Value = "Available Resources";

        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            //Reading data from the Maximum Need Data Grid View
            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                globalDataMembers.maxNeed[i] = new int[globalDataMembers.resourcesCount];

                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    globalDataMembers.maxNeed[i][j] = -1;
                }

                for(int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    while (globalDataMembers.maxNeed[i][j] < 0 || globalDataMembers.maxNeed[i][j].GetType() != typeof(int))
                    {
                        try
                        {

                            if (maxNeedGridView.Rows[i].Cells[j].Value != null)
                            {
                                globalDataMembers.maxNeed[i][j] = int.Parse(maxNeedGridView.Rows[i].Cells[j].Value.ToString());

                            }

                            else
                            {
                                MessageBox.Show("Please enter a valid integer value for maximum need of process " + (i + 1) + " and resource " + (j + 1));
                                return;
                            }

                            if (globalDataMembers.maxNeed[i][j] < 0)
                            {
                                MessageBox.Show("Please enter a valid integer value for maximum need of process " + (i + 1) + " and resource " + (j + 1));
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please enter a valid integer value for maximum need of process " + (i + 1) + " and resource " + (j + 1));
                            return;
                        }
                    }
                }
            }


            //Reading data from the Current Allocation Data Grid View
            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                globalDataMembers.currentAllocation[i] = new int[globalDataMembers.resourcesCount];

                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    globalDataMembers.currentAllocation[i][j] = -1;
                }

                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    while (globalDataMembers.currentAllocation[i][j] < 0 || globalDataMembers.currentAllocation[i][j].GetType() != typeof(int))
                    {
                        try
                        {

                            if (currentAllocationGridView.Rows[i].Cells[j].Value != null)
                            {
                                globalDataMembers.currentAllocation[i][j] = int.Parse(currentAllocationGridView.Rows[i].Cells[j].Value.ToString());

                            }

                            else
                            {
                                MessageBox.Show("Please enter a valid integer value for current allocation of process " + (i + 1) + " and resource " + (j + 1));
                                return;
                            }

                            if (globalDataMembers.currentAllocation[i][j] < 0)
                            {
                                MessageBox.Show("Please enter a valid integer value for current allocation of process " + (i + 1) + " and resource " + (j + 1));
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please enter a valid integer value for current allocation of process " + (i + 1) + " and resource " + (j + 1));
                            return;
                        }
                    }
                }
            }



        }
    }
}