using Mathematica;

var x = new Integrator();


Console.WriteLine(x.Integrate(0, 1, 0.01, x => x * x));

Console.WriteLine(x.Integrate(0, 1, 0.01, x => Math.Sin(x)));

return;
namespace Mathematica
{
    public class Integrator
    {
        public double Integrate(double start, double end, double step, Func<double, double> function)
        {
            var sum = 0.0;

            for (var x = start; x < end; x += step)
            {
                var y = function(x);

                sum += y * step;
            }

            return sum;
        }
    }

}