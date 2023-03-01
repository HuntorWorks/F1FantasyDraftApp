using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DrafteePanel : MonoBehaviour {
    
    [SerializeField] private TextMeshProUGUI drafteeName;
    [SerializeField] private TextMeshProUGUI teamValue;
    // Driver 1 Selection
    [SerializeField] private Image driverSelection1Background;
    [SerializeField] private TextMeshProUGUI driverSelection1Name;
    [SerializeField] private TextMeshProUGUI driverSelection1Value;
    [SerializeField] private Image driverSelection1Portrait; 
    // Driver 2 Selection
    [SerializeField] private Image driverSelection2Background;
    [SerializeField] private TextMeshProUGUI driverSelection2Name;
    [SerializeField] private TextMeshProUGUI driverSelection2Value;
    [SerializeField] private Image driverSelection2Portrait; 
    // Driver 3 Selection
    [SerializeField] private Image driverSelection3Background;
    [SerializeField] private TextMeshProUGUI driverSelection3Name;
    [SerializeField] private TextMeshProUGUI driverSelection3Value;
    [SerializeField] private Image driverSelection3Portrait; 
    // Driver 4 Selection
    [SerializeField] private Image driverSelection4Background;
    [SerializeField] private TextMeshProUGUI driverSelection4Name;
    [SerializeField] private TextMeshProUGUI driverSelection4Value;
    [SerializeField] private Image driverSelection4Portrait; 
    // Driver 5 Selection
    [SerializeField] private Image driverSelection5Background;
    [SerializeField] private TextMeshProUGUI driverSelection5Name;
    [SerializeField] private TextMeshProUGUI driverSelection5Value;
    [SerializeField] private Image driverSelection5Portrait; 
    //Constructor 1 Selection
    [SerializeField] private Image constructorSelection1Background;
    [SerializeField] private TextMeshProUGUI constructorSelection1Name;
    [SerializeField] private TextMeshProUGUI constructorSelection1Value;
    [SerializeField] private Image constructorSelection1Logo;
    //Constructor 2 Selection
    [SerializeField] private Image constructorSelection2Background;
    [SerializeField] private TextMeshProUGUI constructorSelection2Name;
    [SerializeField] private TextMeshProUGUI constructorSelection2Value;
    [SerializeField] private Image constructorSelection2Logo;

    private int driverSelectionNumber = 0;
    private int constructorSelectionNumber = 0;

    private void OnEnable() {
        this.teamValue.text = "0";
    }
    public void SetDriverSelection(DriverSO selectedDriver) {
        switch (driverSelectionNumber) {
            case 0:
                driverSelectionNumber++; 
                break;
            case 1:
                driverSelectionNumber++;
                break;
            case 2:
                driverSelectionNumber++;
                break;
            case 3:
                driverSelectionNumber++;
                break;
            case 4:
                driverSelectionNumber++;
                break; 
        }
    }

    public void SetConstructorSelection(ConstructorSO selectedConstructor) {
        switch (constructorSelectionNumber) {
            case 0:
                constructorSelectionNumber++;
                break;
            case 1:
                constructorSelectionNumber++; 
                break; 
        }
    }

    public void SetDrafteeName(string name) {
        this.drafteeName.text = name; 
    }

    public void ChangeTeamValue(int amount) {
        
    }


}
