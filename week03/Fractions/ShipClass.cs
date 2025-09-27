using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class ShipClass
{
    private int _lenghtShip;
    private int _breadth;
    private int _draft;

    private int _volumeDispacement;

    public ShipClass(int overallLength, int beam, int scantlingdraft, int displacement)
    {
        _lenghtShip = overallLength;
        _breadth = beam;
        _draft = scantlingdraft;
        _volumeDispacement = displacement;

    }

    public double GetBlockCoeffcient()
    {
        double CB = (double)_volumeDispacement / (_lenghtShip * _breadth * _draft);
        return CB;
    }


}