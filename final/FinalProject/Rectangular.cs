public class Rectangular : Section
{
    private double _bottomWidth;


    public Rectangular(double flow, double bottomWidth, double slope, string material) : base (flow, slope, material)
    {
        _bottomWidth = bottomWidth;
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
        return $"Rectangular,{_flow},{_bottomWidth},0,{_slope},{_material},0";
    }
        public override string DisplayResults()
    {
        string displayResults = "\n" +
        "Input Data:\n" +
        $"Flow             :   {_flow}(m3/s) \n" +
        $"Bottom Width     :   {_bottomWidth}(m) \n" +
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