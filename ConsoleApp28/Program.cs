class Program
{
    static void Main()
    {
        PipeController controller = new PipeController();
        controller.CalculatePipeArea();

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}