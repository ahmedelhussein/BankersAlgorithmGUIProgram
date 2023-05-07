# Banker's Algorithm Simulator Program

This is a Windows Forms program that simulates the Banker's Algorithm. It has four forms:

Form 1: This form has a button that, when clicked, opens Form 2.

Form 2: Data Input Form 1: This form takes the number of processes and resources as input from the user, and checks if the entered numbers are valid (non-negative, not null, and integer values).

Form 3: Data Input Form 2: This form has five editable data grid views that allow the user to enter Maximum Need, Current Allocation, Available Resources, and Resources requested by each process. It also has a combobox that allows the user to select the process requesting resources. The entered values are checked for validity (non-negative, not null, and integer values).

Form 4: Simulation Form: This form has three non-editable data grid views:

Available Resources: This data grid view changes dynamically after every safe process is found.
Current Allocation: This data grid view shows the current allocation after adding the resources requested.
Remaining Need: This data grid view shows the remaining need of each process from each resource (Maximum Need - Current Allocation).
After each process is checked for safety, the corresponding row in the Current Allocation and Remaining Need data grid views changes color (green if safe, red otherwise).

The Simulation Form also has a button to start the simulation. When pressed, message boxes appear to inform the user of each process's safety, and when the system is entirely safe, a message box is displayed showing the safe sequence of process execution. If the system is not safe, a message box is displayed informing the user that the system is not safe.

Installation
To install and run the program:

Clone the repository.
Open the solution in Visual Studio.
Build the solution.
Run the program.
Usage
Click the button on Form 1 to open Form 2.
Enter the number of processes and resources in Form 2 and click the "Submit" button.
Enter the values for Maximum Need, Current Allocation, Available Resources, and Resources requested by each process in Form 3. Select the process requesting resources from the combobox.
Click the "Start Simulation" button in Form 4 to begin the simulation.
After the simulation completes, a message box is displayed showing the safe sequence of process execution if the system is safe, or a message box is displayed informing the user that the system is not safe.
Credits
This program was created by [Your Name].
