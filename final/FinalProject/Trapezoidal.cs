public class Trapezoidal : Section
{
    private double _bottomWidth;
    private double _sectionSlope;

    public Trapezoidal(double flow, double bottomWidth, double sectionSlope, double slope, string material) : base (flow, slope, material)
    {
        _bottomWidth = bottomWidth;
        _sectionSlope = sectionSlope;

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
        return $"Trapezoidal,{_flow},{_bottomWidth},{_sectionSlope},{_slope},{_material},0";
    }
    public override string DisplayResults()
    {
        string displayResults = "\n" +
        "Input Data:\n" +
        $"Flow             :   {_flow}(m3/s) \n" +
        $"Bottom Width     :   {_bottomWidth}(m) \n" +
        $"Section Slope    :   {_sectionSlope}(m/m) \n" +
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