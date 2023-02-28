using System.Collections;
using System.Collections.Generic;
using TMPro.SpriteAssetUtilities;
using UnityEngine;

[CreateAssetMenu()]
public class DriverSO : ScriptableObject {
    public string driverName;
    public float driverPrice;
    public Sprite driverPortrait;
    public int driverNumber;
    public Sprite driverNationality;
    public string team; 
}
