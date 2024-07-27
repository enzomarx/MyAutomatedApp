using System;
using WindowsInput;
using WindowsInput.Native;

namespace MyAutomatedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do simulador
            InputSimulator simulator = new InputSimulator();

            // Exemplo de simulação de clique do mouse
            Console.WriteLine("Simulando clique do mouse...");
            simulator.Mouse.MoveMouseBy(100, 100); // Move o mouse 100 pixels à direita e 100 pixels para baixo
            simulator.Mouse.LeftButtonClick(); // Simula o clique do botão esquerdo do mouse

            // Espera de 2 segundos
            System.Threading.Thread.Sleep(2000);

            // Exemplo de simulação de digitação de texto
            Console.WriteLine("Simulando digitação de texto...");
            simulator.Keyboard.TextEntry("Hello, world!"); // Simula a digitação de texto

            // Espera de 2 segundos
            System.Threading.Thread.Sleep(2000);

            // Exemplo de simulação de pressionar e soltar uma tecla
            Console.WriteLine("Simulando pressionamento de tecla...");
            simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN); // Simula o pressionamento da tecla Enter

            // Espera de 2 segundos
            System.Threading.Thread.Sleep(2000);

            // Exemplo de simulação de combinação de teclas
            Console.WriteLine("Simulando combinação de teclas Ctrl+S...");
            simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_S); // Simula Ctrl+S

            // Espera de 2 segundos
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Automação concluída.");
        }
    }
}
