public abstract class Section
{
    protected double _flow;
    protected string _material;
    protected double _coefManning;
    protected double _slope;
    public Section(double flow, double slope, string material)
    {
        _flow = flow;
        _slope = slope;
        _material = material;
        Manning manning = new Manning(_material);
        double _coefManning = manning.GetManning();
    
    }

    public abstract double NormalHeight();
    public abstract double HydraulicArea();
    public abstract double WaterSurface();
    public abstract double Velocity();
    public abstract double WettedPerimeter();
    public abstract double HydraulicRadius();
    public abstract string GetStringRepresentation();
    public abstract string DisplayResults();


}