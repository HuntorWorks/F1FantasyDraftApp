using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Draftee
{
    private string drafteeName;
    private float teamValue;
    private List<DriverSO> selectedDriverSoList = new List<DriverSO>();
    private const int maxDrivers = 5; 
    private List<ConstructorSO> selectedConstructorSoList = new List<ConstructorSO>();
    private const int maxConstructors = 2; 

    public Draftee(string drafteeName)
    {
        this.drafteeName = drafteeName;
        this.teamValue = 0; 
    }

    public string GetDrafteeName() {
        return drafteeName; 
    }

    public float GetTeamValue() {
        return teamValue;
    }

    public void AddTeamValue(float amountToAdd) {
        teamValue += amountToAdd; 
    }

    public void AddDriverToDrafteeList(DriverSO driverSo) {
        if (!(selectedDriverSoList.Count > (maxDrivers - 1))) {
            selectedDriverSoList.Add(driverSo);
        } else {
            Debug.LogError("You are trying to add to many drivers!");
        }
    }

    public void AddConstructorToDrafteeList(ConstructorSO constructorSo) {
        if (!(selectedConstructorSoList.Count > (maxConstructors - 1))) {
            selectedConstructorSoList.Add(constructorSo);
        } else {
            Debug.LogError("You are trying to add to many constructors!");
        }

    }

}
