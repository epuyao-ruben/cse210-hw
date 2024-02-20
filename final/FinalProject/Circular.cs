public class Circular : Section
{
    private double _radius;
    //private double _angle;

    public Circular(double flow, double radius, double slope, string material) : base (flow, slope, material)
    {
        _radius = radius;

    }

    public override double NormalHeight()
    {
        return 0;
    }
    public override double HydraulicArea()
    {
        return 0;
    }
    public override double WaterSurface()
    {
        return 0;
    }
    public override double Velocity()
    {
        return 0;
    }
    public override double WettedPerimeter()
    {
        return 0;
    }
    public override double HydraulicRadius()
    {
        return 0;
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
        $"Material         :   {_material} " +
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