# Banker's Algorithm Simulator Program

This program simulates the banker's algorithm in a Windows Forms Program. It is composed of 4 forms that take input from the user and displays the output of the simulation.

## Form 1 - Start Form
This form simply has a button that when clicked opens Form 2.

![Form 1 Image](/SimulationTestImages/Form1.png "Form1")


## Form 2 - Data Input Form 1
This form takes the number of processes and resources with a button that when pressed checks for the validity of the entered numbers (Ensures that the value is non-negative, not null and is an integer value). After the validation of inputs, the form opens Form 3.

![Data Input Form 1 Image](/SimulationTestImages/DataInputForm1.png "Data Input Form 1")

## Form 3 - Data Input Form 2
This form has 5 editable data grid views and a combobox that take data from the user:

### Data Grid Views
- Maximum Need Data: The maximum number of resources that each process needs.
- Current Allocation: The number of resources that each process is currently allocated.
- Available Resources: The number of resources that are available in the system.
- Resources requested by process: The resources that each process requests.
- Total Resources: The total number of each resource in the system.

### ComboBox
- Process Requesting Resources: The process requesting the resources.

Exception handling is done in all data grid views' values to check for the validity of the entered numbers (Ensures that the value is non-negative, not null and is an integer value). After the validation of inputs, the form opens Form 4.

![Data Input Form 2 Image](/SimulationTestImages/DataInputForm2.png "Data Input Form 2")

## Form 4 - Simulation Form
This form has 3 non-editable data grid views:

- Available Resources: This grid view changes data dynamically after every safe process is found.
- Current Allocation: Shows the current allocation after adding the resources requested.
- Remaining Need: This grid view shows the calculated remaining need of each process from each resource (Maximum Need - Current Allocation).

After each process is checked for safety, the Current Allocation and Remaining Need data grid views in the simulation form row that corresponds to the process change color (If Safe, Color changes to green and changes to red otherwise).

The simulation form also has a button to start the simulation. When pressed, message boxes appear to inform the user of each and every process safety and when the system is entirely safe, a message box informing the user that the system is safe and shows the safe sequence of process execution. Else if it is not safe, a message box showing that the system is not safe is shown.

![Simulation Form 1 Image](/SimulationTestImages/SimulationForm1.png "Simulation Form 1")


![Simulation Form 2 Image](/SimulationTestImages/SimulationForm2.png "Simulation Form 2")


![Simulation Form 3 Image](/SimulationTestImages/SimulationForm3.png "Simulation Form 3")


![Simulation Form 4 Image](/SimulationTestImages/SimulationForm4.png "Simulation Form 4")


![Simulation Form 5 Image](/SimulationTestImages/SimulationForm5.png "Simulation Form 5")

## Requirements
Microsoft Visual Studio 2019 or newer

## Installation and Running the Program
- Clone this repository to your local machine.
- Open the solution file with Visual Studio.
- Build and Run the program.

## Usage
- Click the button on Form 1 to open Form 2.
- Enter the number of processes and resources in Form 2 and click the "Submit" button.
- Enter the values for Maximum Need, Current Allocation, Available Resources, and Resources requested by each process in Form 3. Select the process requesting resources from the combobox.
- Click the "Start Simulation" button in Form 4 to begin the simulation.

After the simulation completes, a message box is displayed showing the safe sequence of process execution if the system is safe, or a message box is displayed informing the user that the system is not safe.

## Credits
This program was created by Ahmed El-Hussein Ahmed.


