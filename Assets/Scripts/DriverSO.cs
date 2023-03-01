using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class DriverSO : ScriptableObject
{
    public string driverName;
    public int driverNumber;
    public float driverPrice;
    public Sprite driverPortrait;
    public Sprite driverNationality;
    public string team; 
    public Color backgroundColor = new Color(); 
}
