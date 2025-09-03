# Windows Forms Application: Student Registration Form

## Overview

This project is a simple Windows Forms application developed in C# that simulates a student registration form. It allows users to input their name, email, password, select their gender, choose their birthday, pick a favorite color, and select their country from a predefined list. Upon submission, the application displays all the entered information.

## Features

*   **User Input Fields**: Textboxes for Name, Email, and Password.
*   **Gender Selection**: Radio buttons for Male, Female, and Other.
*   **Date Picker**: A DateTimePicker control for selecting the birth date.
*   **Color Picker**: A button to open a color dialog for choosing a favorite color.
*   **Country Selection**: A ComboBox pre-populated with a list of countries (Yemen, Saudi Arabia, Egypt, Iraq, Syria, Algeria).
*   **Data Display**: Displays all entered information in a label upon successful submission.
*   **Input Validation**: Basic validation to ensure a gender is selected before submission.

## Project Structure

The project is structured as a standard Windows Forms application. Key files include:

*   `WindowsFormsApp2.sln`: The main solution file for the project.
*   `WindowsFormsApp2/WindowsFormsApp2.csproj`: The project file for the Windows Forms application.
*   `WindowsFormsApp2/Form1.cs`: Contains the C# code for the main form, including event handlers for UI interactions and data processing.
*   `WindowsFormsApp2/Form1.Designer.cs`: Automatically generated code for the form's UI layout and control initialization.
*   `WindowsFormsApp2/Form1.resx`: Resource file for the form, typically containing UI elements and their properties.
*   `WindowsFormsApp2/Program.cs`: The entry point of the application.
*   `WindowsFormsApp2/App.config`: Application configuration file.
*   `Student Registration Form .png`: A screenshot of the application's user interface.

## How to Run

To run this application, you will need Visual Studio with the .NET desktop development workload installed. Follow these steps:

1.  **Open the Solution**: Open the `WindowsFormsApp2.sln` file in Visual Studio.
2.  **Build the Project**: From the Build menu, select 


"Build Solution" or press `Ctrl+Shift+B`.
3.  **Run the Application**: Press `F5` or click the "Start" button in Visual Studio to run the application.

## Usage

1.  Fill in the Name, Email, and Password fields.
2.  Select your Gender using the radio buttons.
3.  Choose your Birthday using the date picker.
4.  Click the "Choose Color" button to select your favorite color from the color dialog.
5.  Select your Country from the dropdown list.
6.  Click the "Submit" button to see your entered information displayed below the form.

## Dependencies

This project requires the .NET Framework (version used in the project is likely 4.7.2 or later, given the typical Visual Studio project setup for Windows Forms). No external libraries or NuGet packages are explicitly referenced beyond the standard .NET framework components for Windows Forms applications.

## Screenshot

A screenshot of the application is included in the project directory:

*   `Student Registration Form .png`

