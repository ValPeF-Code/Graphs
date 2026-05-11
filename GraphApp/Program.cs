using System;
using ScottPlot;

class Program
{
    static void Main()
    {
        int pointCount = 500;
        double[] xs = new double[pointCount];
        double[] ys = new double[pointCount];

        double min = -10;
        double max = 10;

        for (int i = 0; i < pointCount; i++)
        {
            double x = min + (max - min) * i / pointCount;
            xs[i] = x;

            // Change this function
            ys[i] = Math.Sqrt(Math.Abs(x));

            // Run and open graph.png
        }

        var plt = new Plot();

        plt.Add.Scatter(xs, ys);
        plt.Title("y = sin(x) + x");

        plt.SavePng("graph.png", 800, 600);

        Console.WriteLine("Graph saved as graph.png");
    }
}