public class PipeController
{
    private ConsoleView view;

    public PipeController()
    {
        view = new ConsoleView();
    }

    public void CalculatePipeArea()
    {
        double innerRadius, outerRadius;

        Console.Write("Введите внутренний радиус трубы: ");
        double.TryParse(Console.ReadLine(), out innerRadius);

        Console.Write("Введите внешний радиус трубы: ");
        double.TryParse(Console.ReadLine(), out outerRadius);

        Pipe pipe = new Pipe { InnerRadius = innerRadius, OuterRadius = outerRadius };
        double area = pipe.CalculateArea();

        view.DisplayResult(area);
    }
}