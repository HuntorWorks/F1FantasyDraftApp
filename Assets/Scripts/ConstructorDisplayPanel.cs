using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConstructorDisplayPanel : MonoBehaviour
{

    [SerializeField] private List<ConstructorSO> constructorSoList;
    [SerializeField] private TextMeshProUGUI constructorName;
    [SerializeField] private TextMeshProUGUI constructorPrice;
    [SerializeField] private UnityEngine.UI.Image constructorLogoSprite;
    [SerializeField] private UnityEngine.UI.Image constructorCarSprite;
    [SerializeField] private UnityEngine.UI.Image backgroundColor;

    [SerializeField] private int amountOfSpin = 10;
    [SerializeField] private float timeBeforeNextSpin = 0.75f;


    private void Update() {
        HandleInput();

    }
    private void HandleInput() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            StartCoroutine(SelectConstructor());
        }
    }

    private IEnumerator SelectConstructor() {
        for (int i = 0; i < amountOfSpin; i++) {
            ConstructorSO currentDriverSO = constructorSoList[GetRandomConstructorSOIndex()];
            yield return StartCoroutine(DriverSpinAnimtion(currentDriverSO));
            yield return new WaitForSeconds(timeBeforeNextSpin);
        }

    }

    private int GetRandomConstructorSOIndex() {
        int randomDriverSO = Random.Range(0, constructorSoList.Count);
        return randomDriverSO;
    }

    private IEnumerator DriverSpinAnimtion(ConstructorSO constructorSO) {
        ChangeDisplay(constructorSO);
        yield return new WaitForSeconds(timeBeforeNextSpin);
    }

    private void ChangeDisplay(ConstructorSO constructorSO) {
        ChangeBackgroundColor(constructorSO);
        this.constructorName.SetText(constructorSO.constructorName);
        this.constructorPrice.SetText(constructorSO.constructorPrice.ToString() + " Million");
        this.constructorLogoSprite.sprite = constructorSO.teamLogoSprite;
        this.constructorCarSprite.sprite = constructorSO.carSprite;
    }

    private void ChangeBackgroundColor(ConstructorSO constructorSO) {
        switch (constructorSO.name) {
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
            case "Alpha Tauri":
                backgroundColor.color = new Color(DivideBy255(76), DivideBy255(121), DivideBy255(152));
                break;
            case "Alfa Romeo":
                backgroundColor.color = new Color(DivideBy255(177), DivideBy255(32), DivideBy255(56));
                break;
            case "Williams":
                backgroundColor.color = new Color(DivideBy255(54), DivideBy255(190), DivideBy255(221));
                break;
            case "Mclaren":
                backgroundColor.color = new Color(DivideBy255(234), DivideBy255(122), DivideBy255(31));
                break;
            case "Aston Martin":
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
