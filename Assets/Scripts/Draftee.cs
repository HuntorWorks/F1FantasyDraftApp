using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Draftee
{
    private string drafteeName;
    private float teamValue;
    private List<ConstructorSO> selectedDriverSoList;
    private const int maxDrivers = 5; 
    private List<ConstructorSO> selectedConstructorSoList;
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

}
