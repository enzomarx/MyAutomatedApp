# MyAutomatedApp

**MyAutomatedApp** is a C# automation application that allows users to configure and execute automated actions on their system. With a simple graphical interface, API integration, and support for running as a Windows service in the background, MyAutomatedApp is a powerful solution for automating repetitive and complex tasks.

## Features

- **Graphical Interface (WPF):** Intuitive configuration through a user-friendly graphical interface.
- **API Integration:** Ability to interact with external APIs to fetch or send data.
- **Background Execution:** Can be run as a Windows service for continuous, unattended automation.

## Project Structure

- **MyAutomatedApp:** Main application with a graphical interface (WPF).
- **MyAutomatedAppService:** Windows service that runs automation in the background.

## Prerequisites

- .NET SDK 6.0 or higher
- Visual Studio Code or Visual Studio (optional, for development)

### Environment Setup

1. **Clone the repository:**

   ```bash
   git clone https://github.com/username/MyAutomatedApp.git
   cd MyAutomatedApp
   ```

2. **Restore dependencies:**

   ```bash
   dotnet restore
   ```

### Run the WPF Application

1. **Build and Run:**

   ```bash
   dotnet build
   dotnet run --project MyAutomatedApp
   ```

2. **Usage:**
   - Open the WPF application.
   - Enter the desired values for `Mouse Move X`, `Mouse Move Y`, and `Text to Type`.
   - Click "Start Automation" to initiate the automation.

### Run the Windows Service

1. **Install the Service:**

   ```bash
   sc create MyAutomatedAppService binPath= "path\to\MyAutomatedAppService.exe"
   ```

2. **Start the Service:**

   ```bash
   sc start MyAutomatedAppService
   ```

3. **Stop and Delete the Service:**

   ```bash
   sc stop MyAutomatedAppService
   sc delete MyAutomatedAppService
   ```

## Configuration

- **appsettings.json (MyAutomatedApp):** Configuration for automation settings such as mouse movement values and text to be typed.
- **appsettings.json (MyAutomatedAppService):** Configuration for the Windows service.

## Usage Examples

### Graphical Interface

The graphical interface allows you to easily and intuitively set automation parameters:

- `Mouse Move X`: Movement of the mouse in the X direction.
- `Mouse Move Y`: Movement of the mouse in the Y direction.
- `Text to Type`: Text to be automatically typed.

### Windows Service

The Windows service runs automation in the background, allowing the automation process to continue running without direct user interaction.

## Contributing

Contributions are welcome! Please submit pull requests or open issues to report bugs or suggest improvements.

## License

This project is licensed under the MIT License.

## Contact

- **Email:** enzomarxsantos@gmail.com
