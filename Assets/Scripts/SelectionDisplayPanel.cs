using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SelectionDisplayPanel : MonoBehaviour {
    [Header("Driver Selection")]
    [SerializeField] private Transform driverSelection;
    [SerializeField] private List<DriverSO> driverSoList;
    [SerializeField] private TextMeshProUGUI driverName;
    [SerializeField] private TextMeshProUGUI driverNumber;
    [SerializeField] private TextMeshProUGUI driverPrice;
    [SerializeField] private Image driverPortrait;
    [SerializeField] private Image driverNationality;
    [SerializeField] private Image driverBackgroundColor;

    [Header("Constructor Selection")]
    [SerializeField] private Transform constructorSelection; 
    [SerializeField] private List<ConstructorSO> constructorSoList;
    [SerializeField] private TextMeshProUGUI constructorName;
    [SerializeField] private TextMeshProUGUI constructorPrice;
    [SerializeField] private Image constructorLogoSprite;
    [SerializeField] private Image constructorCarSprite;
    [SerializeField] private Image constructorBackgroundColor;

    [SerializeField] private int amountOfSpin = 20;
    [SerializeField] private float timeBeforeNextSpin = .75f;

    private DriverSO currentSelectedDriverSO;
    private ConstructorSO currentSelectedConstructorSO;
    private int typeOfSelection = 1; //1 Driver, 2 constructor


    private void Start() {
        RandomSelectionAtStart randomDriverSelectionAtStart = driverSelection.GetComponent<RandomSelectionAtStart>();
        RandomSelectionAtStart randomConstructorSelectionAtStart = constructorSelection.GetComponent<RandomSelectionAtStart>();
        
        randomDriverSelectionAtStart.OnEnableEvent.AddListener(OnDriverSelectionChange);
        randomConstructorSelectionAtStart.OnEnableEvent.AddListener(OnConstructorSelectionChange);

    }

    private void OnConstructorSelectionChange() {
        ChangeDisplay(RandomConstructorSelectionAtFirstLoad(constructorSoList));
        Debug.Log("ConstructorSelected!");
    }

    private void OnDriverSelectionChange() {
        ChangeDisplay(RandomDriverSelectionAtFirstLoad(driverSoList));
        Debug.Log("DriverSelected!");
    }

    private void Update()
    {
        HandleInput();

    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Select(typeOfSelection));
        }
    }

    private DriverSO RandomDriverSelectionAtFirstLoad(List<DriverSO> driverList) {
        int randomSelectionIndex = Random.Range(0, driverList.Count);
        DriverSO randomSelectedDriver = driverList[randomSelectionIndex];
        return randomSelectedDriver;

    }

    private ConstructorSO RandomConstructorSelectionAtFirstLoad(List<ConstructorSO> constructorList) {
        int randomSelectionIndex = Random.Range(0, constructorList.Count);
        ConstructorSO randomSelectedConstructor = constructorList[randomSelectionIndex];
        return randomSelectedConstructor;
    }

    private IEnumerator Select(int selectionType)
    {
        for (int i = 0; i < amountOfSpin; i++) {
            if (selectionType == 1) {
                currentSelectedDriverSO = driverSoList[GetRandomIndex(driverSoList)];
                yield return StartCoroutine(SpinAnimtion(currentSelectedDriverSO));
                yield return new WaitForSeconds(timeBeforeNextSpin);
            } else if (selectionType == 2) {
                currentSelectedConstructorSO = constructorSoList[GetRandomIndex(constructorSoList)];
                yield return StartCoroutine(SpinAnimtion(currentSelectedConstructorSO));
                yield return new WaitForSeconds(timeBeforeNextSpin);
            }
        }
        //Send to panel
        switch (selectionType)
        {
          case 1:
              break;
          case 2:
              break;
        }
        
    }

    private int GetRandomIndex(List<DriverSO> driverSoList)
    {
        int randomDriverSO = Random.Range(0, driverSoList.Count);
        return randomDriverSO;
    }

    private int GetRandomIndex(List<ConstructorSO> constructorSoList) {
        int randomConstructorSO = Random.Range(0, constructorSoList.Count);
        return randomConstructorSO;
    }

    private IEnumerator SpinAnimtion(DriverSO driverSo)
    {
        ChangeDisplay(driverSo);
        yield return new WaitForSeconds(timeBeforeNextSpin);
    }

    private IEnumerator SpinAnimtion(ConstructorSO constructorSo) {
        ChangeDisplay(constructorSo);
        yield return new WaitForSeconds(timeBeforeNextSpin);
    }
    

    private void ChangeDisplay(DriverSO driverSo) {
        driverBackgroundColor.color = new Color(driverSo.backgroundColor.r, driverSo.backgroundColor.g, driverSo.backgroundColor.b);
        this.driverName.SetText(driverSo.driverName);
        this.driverNumber.SetText(driverSo.driverNumber.ToString());
        this.driverPrice.SetText(driverSo.driverPrice.ToString() + " Million");
        this.driverPortrait.sprite = driverSo.driverPortrait;
        this.driverNationality.sprite = driverSo.driverNationality;
    }

    private void ChangeDisplay(ConstructorSO constructorSo) {
        constructorBackgroundColor.color = new Color(constructorSo.backgroundColor.r,constructorSo.backgroundColor.g,constructorSo.backgroundColor.b); 
        this.constructorName.SetText(constructorSo.constructorName);
        this.constructorPrice.SetText(constructorSo.constructorPrice.ToString() + " Million");
        this.constructorCarSprite.sprite = constructorSo.carSprite;
        this.constructorLogoSprite.sprite = constructorSo.teamLogoSprite;
    }

    public void SetSelectionType(string selectionType) {
        if (selectionType == "driver") {
            typeOfSelection = 1; 
        } else if (selectionType == "constructor") {
            typeOfSelection = 2; 
        }
    } 
}
