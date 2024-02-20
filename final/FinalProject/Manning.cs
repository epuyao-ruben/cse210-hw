public class Manning
{
    private string _material;
    public Manning(string material)
    {
        _material = material.ToLower();
    }
    public double GetManning()
    {
        if (_material == "concrete")
        {
            return 0.013;
        }
        else if (_material == "steel")
        {
            return 0.012;
        }
        else if (_material == "hdpe")
        {
            return 0.011;
        }
        else if (_material == "asphalt")
        {
            return 0.011;
        }
        else if (_material == "terrain")
        {
            return 0.025;
        }
        else 
        {
            return 0;
        }

    }
}