public class RoadSection : Section
{
    private double _roadSlope;

    public RoadSection(double flow, double roadSlope, double slope, string material) : base (flow, slope, material)
    {
        _roadSlope = roadSlope;

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
        return $"RoadSection,{_flow},0,{_roadSlope},{_slope},{_material},0";
    }
        public override string DisplayResults()
    {
        string displayResults = "\n" +
        "Input Data:\n" +
        $"Flow             :   {_flow}(m3/s) \n" +
        $"Section Slope    :   {_roadSlope}(m/m) \n" +
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