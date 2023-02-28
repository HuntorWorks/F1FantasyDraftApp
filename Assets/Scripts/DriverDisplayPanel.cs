using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;

public class DriverDisplayPanel : MonoBehaviour {
    
    [SerializeField] private List<DriverSO> driverSoList;
    [SerializeField] private TextMeshProUGUI driverName;
    [SerializeField] private TextMeshProUGUI driverNumber;
    [SerializeField] private TextMeshProUGUI driverPrice;
    [SerializeField] private UnityEngine.UI.Image driverPortrait;
    [SerializeField] private UnityEngine.UI.Image driverNationality;
    [SerializeField] private UnityEngine.UI.Image backgroundColor;

    [SerializeField] private int amountOfSpin = 6;
    [SerializeField] private float timeBeforeNextSpin = 1f;



    private void Update() {
        HandleInput();

    }
    private void HandleInput() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(SelectDriver());
        }
    }

    private IEnumerator SelectDriver() {
            for(int i = 0; i < amountOfSpin; i++) {
                DriverSO currentDriverSO = driverSoList[GetRandomDriverSOIndex()];
                yield return StartCoroutine(DriverSpinAnimtion(currentDriverSO));
                yield return new WaitForSeconds(timeBeforeNextSpin);
            }

    }

    private int GetRandomDriverSOIndex() {
        int randomDriverSO = Random.Range(0, driverSoList.Count);
        return randomDriverSO;
    }

    private IEnumerator DriverSpinAnimtion(DriverSO driverSo) {
         ChangeDisplay(driverSo); 
        yield return new WaitForSeconds(timeBeforeNextSpin);
    }

    private void ChangeDisplay(DriverSO driverSo) {
        ChangeBackgroundColor(driverSo);
        this.driverName.SetText(driverSo.driverName);
        this.driverNumber.SetText(driverSo.driverNumber.ToString());
        this.driverPrice.SetText(driverSo.driverPrice.ToString() + " Million");
        this.driverPortrait.sprite = driverSo.driverPortrait;
        this.driverNationality.sprite = driverSo.driverNationality;
    }

    private void ChangeBackgroundColor(DriverSO driverSo) {
        switch(driverSo.team)
        {
            case "RedBull":
                backgroundColor.color = new Color(31, 91, 197);
                break;
            case "Ferarri":
                backgroundColor.color = new Color(231, 28, 35);
                break;
            case "Mercedes":
                backgroundColor.color = new Color(0, 207, 186);
                break;
            case "Alpine":
                backgroundColor.color = new Color(32, 139, 197);
                break;
            case "AlphaTauri":
                backgroundColor.color = new Color(245, 241, 238);
                break;
            case "AlfaRomeo":
                backgroundColor.color = new Color(177, 32, 56);
                break;
            case "Williams":
                backgroundColor.color = new Color(54, 190, 221);
                break;
            case "Mclaren":
                backgroundColor.color = new Color(234, 122, 31);
                break;
            case "AstonMartin":
                backgroundColor.color = new Color(44, 129, 108);
                break;
            case "Haas":
                backgroundColor.color = new Color(164, 168, 171);
                break;
        }

    }


}
