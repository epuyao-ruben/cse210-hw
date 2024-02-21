using System.Reflection.Emit;

public class Rectangular : Section
{
    private double _bottomWidth;


    public Rectangular(double flow, double bottomWidth, double slope, string material) : base(flow, slope, material)
    {
        _bottomWidth = bottomWidth;
        Manning manning = new Manning(material);
        _coefManning = Math.Round(manning.GetManning(), 3);
    }

    public override double NormalHeight()
    {
        // Initial Calc
        double Q = _flow;
        double N = _coefManning;
        double Z1 = 0;
        double B = _bottomWidth;
        double Z2 = Z1;
        double S = _slope;

        double C = Q * N / Math.Pow(S, 0.5);
        double Yi = 1.5;
        double Yf = 1.2;

        //iteration calc for Yf
        for (int i = 0; i < 40; i++)
        {
            double temp = Yf;
            Yf = Yi - (Math.Pow(B * Yi + ((Z1 + Z2) / 2) * Math.Pow(Yi, 2), 5.0 / 3) /
                Math.Pow(B + Yi * Math.Sqrt(1 + Z1 * Z1) + Yi * Math.Sqrt(1 + Z2 * Z2), 2.0 / 3) - C) /
                ((5.0 / 3) * Math.Pow(B + Yi * Math.Sqrt(1 + Z1 * Z1) + Yi * Math.Sqrt(1 + Z2 * Z2), -2.0 / 3) *
                Math.Pow(B * Yi + ((Z1 + Z2) / 2) * Math.Pow(Yi, 2), 2.0 / 3) *
                (B + (Z1 + Z2) * Yi) - (2.0 / 3) * Math.Pow(B * Yi + ((Z1 + Z2) / 2) * Math.Pow(Yi, 2), 5.0 / 3) *
                Math.Pow(B + Yi * Math.Sqrt(1 + Z1 * Z1) + Yi * Math.Sqrt(1 + Z2 * Z2), -5.0 / 3) *
                (Math.Sqrt(1 + Z1 * Z1) + Math.Sqrt(1 + Z2 * Z2)));

            Yi = temp;
        }
        return Math.Round(Yf, 4);
    }
    public override double HydraulicArea()
    {
        //Variables
        double B = _bottomWidth;
        double Yf = NormalHeight();

        double A = Yf * B;
        return Math.Round(A, 4);
    }
    public override double WaterSurface()
    {
        //Variables
        double B = _bottomWidth;

        //Calc
        double E = B;
        return Math.Round(E, 4);
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
        //Variables
        double B = _bottomWidth;
        double Yf = NormalHeight();

        //Calc
        double P = B + 2 * Yf;
        return Math.Round(P, 4);
    }
    public override double HydraulicRadius()
    {
        //Variables
        double B = _bottomWidth;
        double Yf = NormalHeight();

        //Calc
        double H = Yf * B / (B + 2 * Yf);

        return Math.Round(H, 4);
    }
    public override string GetStringRepresentation()
    {
        //Section, Flow, Bottom Width, Section Slope, Slope, Material, Radius
        return $"Rectangular,{_flow},{_bottomWidth},0,{_slope},{_material},0";
    }
    public override string DisplayResults()
    {
        string displayResults = "\n" +
        "Input Data:\n" +
        $"Flow             :   {_flow}(m3/s) \n" +
        $"Bottom Width     :   {_bottomWidth}(m) \n" +
        $"Slope            :   {_slope}(m/m) \n" +
        $"Material         :   {_material} \n" +
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