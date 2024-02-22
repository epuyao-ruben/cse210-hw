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
            // Initial varaibles
            double D = 2 * _radius;
            double Q = _flow;
            double S = _slope;
            double n = _coefManning;

            //iteration variables
            double accuracy = 1e-6; // Precition 
            double maxIterations = 100; // Max cuantity of iterationss
            double theta = 1; // proposal initial value 

            // Method - Newton-Raphson
            for (int i = 0; i < maxIterations; i++)
            {
                // Console.Clear();
                // Console.WriteLine($"Q: {Q}");
                // Console.WriteLine($"D: {D}");
                // Console.WriteLine($"S: {S}");
                // Console.WriteLine($"tn: {n}");
                double K = Math.Pow(4, 2.0 / 3) * 8 * Q * n / (Math.Sqrt(S) * Math.Pow(D, 8.0 / 3));
                //Console.WriteLine($"K: {K}");
                
                double f = (theta - Math.Sin(theta)) * Math.Pow((1 - Math.Sin(theta) / theta), 2.0 / 3) - K;
                //Console.WriteLine($"f(theta): {f}");
                
                double df = (2 * Math.Sin(theta) * (Math.Cos(theta) / theta - Math.Sin(theta) / (theta * theta))) /
                           (3 * Math.Pow((1 - Math.Sin(theta) / theta), 1.0 / 3)) -
                           Math.Cos(theta) * Math.Pow((1 - Math.Sin(theta) / theta), 2.0 / 3) + 1;
                //Console.WriteLine($"df: {df}");
            
                theta -= f / df; // Actualización del tirante
                

                if (Math.Abs(f) < accuracy)
                    break; // Condición de convergencia
            }

            double y = (1-Math.Cos(theta/2))*(D/2);
            
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