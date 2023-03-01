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
        InitialSetUp();
        this.teamValue.text = "0.0 M";
    }
    public void SetDriverSelection(DriverSO selectedDriver) {
        switch (driverSelectionNumber) {
            case 0:
                driverSelection1Background.color = new Color(selectedDriver.backgroundColor.r, selectedDriver.backgroundColor.g, selectedDriver.backgroundColor.b);
                driverSelection1Name.gameObject.SetActive(true);
                driverSelection1Name.text = selectedDriver.driverName;
                driverSelection1Value.gameObject.SetActive(true);
                driverSelection1Value.text = selectedDriver.driverPrice.ToString();
                driverSelection1Portrait.gameObject.SetActive(true);
                driverSelection1Portrait.sprite = selectedDriver.driverPortrait;
                driverSelectionNumber++; 
                break;
            case 1:
                driverSelection2Background.color = new Color(selectedDriver.backgroundColor.r, selectedDriver.backgroundColor.g, selectedDriver.backgroundColor.b);
                driverSelection2Name.gameObject.SetActive(true);
                driverSelection2Name.text = selectedDriver.driverName;
                driverSelection2Value.gameObject.SetActive(true);
                driverSelection2Value.text = selectedDriver.driverPrice.ToString();
                driverSelection2Portrait.gameObject.SetActive(true);
                driverSelection2Portrait.sprite = selectedDriver.driverPortrait;
                driverSelectionNumber++; 
                break;
            case 2:
                driverSelection3Background.color = new Color(selectedDriver.backgroundColor.r, selectedDriver.backgroundColor.g, selectedDriver.backgroundColor.b);
                driverSelection3Name.gameObject.SetActive(true);
                driverSelection3Name.text = selectedDriver.driverName;
                driverSelection3Value.gameObject.SetActive(true);
                driverSelection3Value.text = selectedDriver.driverPrice.ToString();
                driverSelection3Portrait.gameObject.SetActive(true);
                driverSelection3Portrait.sprite = selectedDriver.driverPortrait;
                driverSelectionNumber++; 
                break;
            case 3:
                driverSelection4Background.color = new Color(selectedDriver.backgroundColor.r, selectedDriver.backgroundColor.g, selectedDriver.backgroundColor.b);
                driverSelection4Name.gameObject.SetActive(true);
                driverSelection4Name.text = selectedDriver.driverName;
                driverSelection4Value.gameObject.SetActive(true);
                driverSelection4Value.text = selectedDriver.driverPrice.ToString();
                driverSelection4Portrait.gameObject.SetActive(true);
                driverSelection4Portrait.sprite = selectedDriver.driverPortrait;
                driverSelectionNumber++; 
                break;
            case 4:                
                driverSelection5Background.color = new Color(selectedDriver.backgroundColor.r, selectedDriver.backgroundColor.g, selectedDriver.backgroundColor.b);
                driverSelection5Name.gameObject.SetActive(true);
                driverSelection5Name.text = selectedDriver.driverName;
                driverSelection5Value.gameObject.SetActive(true);
                driverSelection5Value.text = selectedDriver.driverPrice.ToString();
                driverSelection5Portrait.gameObject.SetActive(true);
                driverSelection5Portrait.sprite = selectedDriver.driverPortrait;
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

    public void SetTeamValue(string value) {
        this.teamValue.text = value + " M";
    }

    private void InitialSetUp() {
        driverSelection1Name.gameObject.SetActive(false);
        driverSelection1Value.gameObject.SetActive(false);
        driverSelection1Portrait.gameObject.SetActive(false);
        driverSelection2Name.gameObject.SetActive(false);
        driverSelection2Value.gameObject.SetActive(false);
        driverSelection2Portrait.gameObject.SetActive(false);
        driverSelection3Name.gameObject.SetActive(false);
        driverSelection3Value.gameObject.SetActive(false);
        driverSelection3Portrait.gameObject.SetActive(false);
        driverSelection4Name.gameObject.SetActive(false);
        driverSelection4Value.gameObject.SetActive(false);
        driverSelection4Portrait.gameObject.SetActive(false);
        driverSelection5Name.gameObject.SetActive(false);
        driverSelection5Value.gameObject.SetActive(false);
        driverSelection5Portrait.gameObject.SetActive(false);
        constructorSelection1Name.gameObject.SetActive(false);
        constructorSelection1Value.gameObject.SetActive(false);
        constructorSelection1Logo.gameObject.SetActive(false);
        constructorSelection2Name.gameObject.SetActive(false);
        constructorSelection2Value.gameObject.SetActive(false);
        constructorSelection2Logo.gameObject.SetActive(false);
        
    }



}
