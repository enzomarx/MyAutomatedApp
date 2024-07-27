using System.Windows;

namespace MyAutomatedApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var mouseMoveX = int.Parse(MouseMoveXBox.Text);
            var mouseMoveY = int.Parse(MouseMoveYBox.Text);
            var textToType = TextToTypeBox.Text;

            var settings = new Settings
            {
                MouseMoveX = mouseMoveX,
                MouseMoveY = mouseMoveY,
                TextToType = textToType,
                Delay = 2000
            };

            var automationService = new AutomationService(settings);
            automationService.Start();
        }
    }
}
