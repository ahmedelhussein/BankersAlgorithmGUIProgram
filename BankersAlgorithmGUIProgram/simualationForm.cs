using System;
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
    public partial class simualationForm : Form
    {
        public simualationForm()
        {
            InitializeComponent();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
            //Initializing Available Resources Grid View
            availableResourcesGridView.ColumnCount = globalDataMembers.resourcesCount;
            availableResourcesGridView.RowCount = 1;

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                availableResourcesGridView.Columns[i].Name = "Resource " + (i + 1);
            }

            availableResourcesGridView.Rows[0].HeaderCell.Value = "Available Resources";

            //Calculating the available resources after giving the requesting process its request
            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                globalDataMembers.availableResources[i] = globalDataMembers.availableResources[i] - globalDataMembers.resourcesRequested[i];
            }

            //Displaying the available resources after giving the requesting process its request in the availableResourcesGridView

            // Set up the DataGridView to display the data
            availableResourcesGridView.ColumnCount = globalDataMembers.resourcesCount;
            availableResourcesGridView.RowCount = 1;

            //Loop through the 2D array and add each cell to the DataGridView (availableResourcesGridView)

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                availableResourcesGridView[i, 0].Value = globalDataMembers.availableResources[i];
            }



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Updating Current Allocation 2D Array after giving the requesting process its request
            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                globalDataMembers.currentAllocation[globalDataMembers.processRequesting][i] = globalDataMembers.currentAllocation[globalDataMembers.processRequesting][i] + globalDataMembers.resourcesRequested[i];
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

            // Displaying the current allocation of each process from the each resources in the currentAllocationGridView

            // Set up the DataGridView to display the data
            currentAllocationGridView.ColumnCount = globalDataMembers.resourcesCount;
            currentAllocationGridView.RowCount = globalDataMembers.processesCount;

            // Loop through the 2D array and add each cell to the DataGridView (remainingNeedGridView)

            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    currentAllocationGridView[j, i].Value = globalDataMembers.currentAllocation[i][j];
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Initializing Remaining Need Grid View
            remainingNeedGridView.ColumnCount = globalDataMembers.resourcesCount;
            remainingNeedGridView.RowCount = globalDataMembers.processesCount;

            for (int i = 0; i < globalDataMembers.resourcesCount; i++)
            {
                remainingNeedGridView.Columns[i].Name = "Resource " + (i + 1);
            }

            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                remainingNeedGridView.Rows[i].HeaderCell.Value = "Process " + (i + 1);
            }


            //Calculating the remaining need of each process from the each resources (remaining need = maximum need - current allocation)
            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                globalDataMembers.remainingNeed[i] = new int[globalDataMembers.resourcesCount];

                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    globalDataMembers.remainingNeed[i][j] = -1;
                }

                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    globalDataMembers.remainingNeed[i][j] = globalDataMembers.maxNeed[i][j] - globalDataMembers.currentAllocation[i][j];
                }
            }


            // Displaying the remaining need of each process from the each resources in the remainingNeedGridView

            // Set up the DataGridView to display the data
            remainingNeedGridView.ColumnCount = globalDataMembers.resourcesCount;
            remainingNeedGridView.RowCount = globalDataMembers.processesCount;

            // Loop through the 2D array and add each cell to the DataGridView (remainingNeedGridView)

            for (int i = 0; i < globalDataMembers.processesCount; i++)
            {
                for (int j = 0; j < globalDataMembers.resourcesCount; j++)
                {
                    remainingNeedGridView[j, i].Value = globalDataMembers.remainingNeed[i][j];
                }
            }

        }





    }
}
