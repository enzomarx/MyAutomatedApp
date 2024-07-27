using System;
using System.Net.Http;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;
using Serilog;

namespace MyAutomatedApp
{
    public class AutomationService
    {
        private readonly Settings _settings;

        public AutomationService(Settings settings)
        {
            _settings = settings;
        }

        public void Start()
        {
            Task.Run(() => ExecuteAutomation());
        }

        private async Task ExecuteAutomation()
        {
            Log.Information("Starting automation...");

            var simulator = new InputSimulator();

            try
            {
                Log.Information("Simulating mouse click...");
                simulator.Mouse.MoveMouseBy(_settings.MouseMoveX, _settings.MouseMoveY);
                simulator.Mouse.LeftButtonClick();

                await Task.Delay(_settings.Delay);

                Log.Information("Simulating text entry...");
                simulator.Keyboard.TextEntry(_settings.TextToType);

                await Task.Delay(_settings.Delay);

                Log.Information("Simulating key press...");
                simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                await Task.Delay(_settings.Delay);

                Log.Information("Simulating Ctrl+S...");
                simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_S);

                await Task.Delay(_settings.Delay);

                Log.Information("Automation completed successfully.");

                // Example API call
                using var client = new HttpClient();
                var response = await client.GetStringAsync("https://api.example.com/data");
                Log.Information("API Response: " + response);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occurred during automation.");
            }
        }
    }
}
