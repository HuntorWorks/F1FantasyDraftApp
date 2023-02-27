using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class DriverDisplayPanel : MonoBehaviour {
    
    [SerializeField] private List<DriverSO> driverSoList;
    [SerializeField] private TextMeshProUGUI driverName;
    [SerializeField] private TextMeshProUGUI driverNumber;
    [SerializeField] private TextMeshProUGUI driverPrice;
    [SerializeField] private UnityEngine.UI.Image driverPortrait;
    [SerializeField] private UnityEngine.UI.Image driverNationality;

    [SerializeField] private int amountOfSpin = 6; 
    
    private void Awake() {
        for (int i = 0; i < amountOfSpin; i++) {
            DriverSO currentDriverSo = driverSoList[i];
            this.driverName.SetText(currentDriverSo.driverName);
            this.driverNumber.SetText(currentDriverSo.driverNumber.ToString());
            this.driverPrice.SetText(currentDriverSo.driverPrice.ToString() + " Million");
            this.driverPortrait.sprite = currentDriverSo.driverPortrait;
            this.driverNationality.sprite = currentDriverSo.driverNationality; 
        }

    }
}
