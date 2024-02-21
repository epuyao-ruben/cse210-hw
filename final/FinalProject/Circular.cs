using System.Data.Common;

public class Circular : Section
{
    private double _radius;
    //private double _angle;

    public Circular(double flow, double radius, double slope, string material) : base(flow, slope, material)
    {
        _radius = radius;
        Manning manning = new Manning(material);
        _coefManning = Math.Round(manning.GetManning(), 3);

    }

    public override double NormalHeight()
    {
        {
            //Console.Clear();
            // Parámetros iniciales
            double D = 2 * _radius;
            double Q = _flow;
            double S = _slope;
            double n = _coefManning;

            double accuracy = 1e-6; // Precisión deseada
            double maxIterations = 100; // Número máximo de iteraciones
            double y = 1; // Suponemos un tirante inicial

            // Método de Newton-Raphson
            for (int i = 0; i < maxIterations; i++)
            {
                double theta = 2 * Math.Acos(1 - 2 * y / D);
                Console.WriteLine(theta);
                //double K = Math.Pow(4, 2.0 / 3) * 8 * Q * n / (Math.Pow(S, 0.5) * Math.Pow(D, 8.0 / 3));
                Console.WriteLine($"Yi: {y}");
                double f = y * y - y * D + Math.Pow(Math.Sin(theta / 2), 2) * ((D * D) / 4);
                Console.WriteLine($"f(y): {f}");
                double df = 2 * y - D;
                Console.WriteLine($"df(y): {df}");
                Console.WriteLine();

                y -= f / df; // Actualización del tirante

                if (Math.Abs(f) < accuracy)
                    break; // Condición de convergencia
            }

            return Math.Round(y, 4);
        }
    }
    public override double HydraulicArea()
    {
        double D = 2 * _radius;
        double y = NormalHeight();
        double theta = 2 * Math.Acos(1 - 2 * y / D);
        double A = D*D*(theta-Math.Sin(theta))/8;

        return Math.Round(A, 4);
    }
    public override double WaterSurface()
    {
        double D = 2 * _radius;
        double y = NormalHeight();
        double T =  2 * Math.Sqrt(y*(D-y));

        return Math.Round(T, 4);
    }
    public override double Velocity()
    {
        //Variables
        double Q = _flow;
        double A = HydraulicArea();

        //Calc
        double V = Q / A;
        return Math.Round(V, 4);
    }
    public override double WettedPerimeter()
    {
        double D = 2 * _radius;
        double y = NormalHeight();
        double theta = 2 * Math.Acos(1 - 2 * y / D);

        double P = theta * D / 2;
        return Math.Round(P, 4);
    }
    public override double HydraulicRadius()
    {
        double D = 2 * _radius;
        double y = NormalHeight();
        double theta = 2 * Math.Acos(1 - 2 * y / D);

        double R = (D/4)*(1-Math.Sin(theta)/theta);
        return Math.Round(R, 4);
    }
    public override string GetStringRepresentation()
    {
        //Section, Flow, Bottom Width, Section Slope, Slope, Material, Radius
        return $"Circular,{_flow},0,0,{_slope},{_material},{_radius}";
    }
    public override string DisplayResults()
    {
        string displayResults = "\n" +
        "Input Data:\n" +
        $"Flow             :   {_flow}(m3/s) \n" +
        $"Radius           :   {_radius}(m) \n" +
        $"Slope            :   {_slope}(m/m) \n" +
        $"Material         :   {_material} \n" +
        $"Coef. Manning    :   {_coefManning} \n" +
        "\n" +
        "Results:\n" +
        $"Normal Height    :   {NormalHeight()}(m) \n" +
        $"Hydraulic Area   :   {HydraulicArea()}(m2) \n" +
        $"Water Surface    :   {WaterSurface()}(m) \n" +
        $"Velocity         :   {Velocity()}(m/s) \n" +
        $"Wetted Perimeter :   {WettedPerimeter()}(m) \n" +
        $"Hydraulic Radius :   {HydraulicRadius()}(m) \n";
        return displayResults;
    }

}