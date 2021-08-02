using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    private double _x;

    private double _y;

    private double _z;

    public Location(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public double GetX()
    {
        return _x;
    }

    public void SetX(double x)
    {
        _x = x;
    }
    
    public double GetY()
    {
        return _y;
    }

    public void SetY(double y)
    {
        _y = y;
    }
    
    public double GetZ()
    {
        return _z;
    }

    public void SetZ(double z)
    {
        _z = z;
    }
}
