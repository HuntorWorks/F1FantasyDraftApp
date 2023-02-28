using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Color = UnityEngine.Color;

public class DriverDisplayPanel : MonoBehaviour
{

    [SerializeField] private List<DriverSO> driverSoList;
    [SerializeField] private TextMeshProUGUI driverName;
    [SerializeField] private TextMeshProUGUI driverNumber;
    [SerializeField] private TextMeshProUGUI driverPrice;
    [SerializeField] private UnityEngine.UI.Image driverPortrait;
    [SerializeField] private UnityEngine.UI.Image driverNationality;
    [SerializeField] private UnityEngine.UI.Image backgroundColor;

    [SerializeField] private int amountOfSpin = 20;
    [SerializeField] private float timeBeforeNextSpin = 1f;



    private void Update()
    {
        HandleInput();

    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SelectDriver());
        }
    }

    private IEnumerator SelectDriver()
    {
        for (int i = 0; i < amountOfSpin; i++)
        {
            DriverSO currentDriverSO = driverSoList[GetRandomDriverSOIndex()];
            yield return StartCoroutine(DriverSpinAnimtion(currentDriverSO));
            yield return new WaitForSeconds(timeBeforeNextSpin);
        }

    }

    private int GetRandomDriverSOIndex()
    {
        int randomDriverSO = Random.Range(0, driverSoList.Count);
        return randomDriverSO;
    }

    private IEnumerator DriverSpinAnimtion(DriverSO driverSo)
    {
        ChangeDisplay(driverSo);
        yield return new WaitForSeconds(timeBeforeNextSpin);
    }

    private void ChangeDisplay(DriverSO driverSo)
    {
        ChangeBackgroundColor(driverSo);
        this.driverName.SetText(driverSo.driverName);
        this.driverNumber.SetText(driverSo.driverNumber.ToString());
        this.driverPrice.SetText(driverSo.driverPrice.ToString() + " Million");
        this.driverPortrait.sprite = driverSo.driverPortrait;
        this.driverNationality.sprite = driverSo.driverNationality;
    }

    private void ChangeBackgroundColor(DriverSO driverSo)
    {
        switch (driverSo.team)
        {
            case "RedBull":
                backgroundColor.color = new Color(DivideBy255(31), DivideBy255(91), DivideBy255(197));
                break;
            case "Ferarri":
                backgroundColor.color = new Color(DivideBy255(231), DivideBy255(28), DivideBy255(35));
                break;
            case "Mercedes":
                backgroundColor.color = new Color(DivideBy255(0), DivideBy255(207), DivideBy255(186));
                break;
            case "Alpine":
                backgroundColor.color = new Color(DivideBy255(32), DivideBy255(139), DivideBy255(197));
                break;
            case "AlphaTauri":
                backgroundColor.color = new Color(DivideBy255(76), DivideBy255(121), DivideBy255(152));
                break;
            case "AlfaRomeo":
                backgroundColor.color = new Color(DivideBy255(177), DivideBy255(32), DivideBy255(56));
                break;
            case "Williams":
                backgroundColor.color = new Color(DivideBy255(54), DivideBy255(190), DivideBy255(221));
                break;
            case "Mclaren":
                backgroundColor.color = new Color(DivideBy255(234), DivideBy255(122), DivideBy255(31));
                break;
            case "AstonMartin":
                backgroundColor.color = new Color(DivideBy255(44), DivideBy255(129), DivideBy255(108));
                break;
            case "Haas":
                backgroundColor.color = new Color(DivideBy255(164), DivideBy255(168), DivideBy255(171));
                break;
        }
    }

    private float DivideBy255(int RGBValueToDivide) {

        return RGBValueToDivide / 255f; 

    }
}
