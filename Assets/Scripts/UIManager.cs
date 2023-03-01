using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    
    [SerializeField] private GameObject driverSelectionDisplayPanel;
    [SerializeField] private GameObject constructorSelectionDisplayPanel;
    [SerializeField] private GameObject selectionTypeCanvas;
    [SerializeField] private GameObject amountOfDrafteesInputBox;
    [SerializeField] private GameObject drafteeNumber1InputField;
    [SerializeField] private GameObject drafteeNumber2InputField;
    [SerializeField] private GameObject drafteeNumber3InputField;
    [SerializeField] private GameObject drafteeNumber4InputField;
    
    [SerializeField] private TextMeshProUGUI setUpText;

    [SerializeField] private GameObject drafteePanel;
    [SerializeField] private GameObject drafteePanelConatiner;

    private List<String> drafteeNames = new List<string>();
    [SerializeField] private GameObject drafteePanel1;
    [SerializeField] private GameObject drafteePanel2;
    [SerializeField] private GameObject drafteePanel3;
    [SerializeField] private GameObject drafteePanel4;
    
    public event EventHandler OnSelectionSwitch; //Event that fires when there is a selection switch and subscribed to in 'RandomSelectionAtStart'

    private int amountOfDraftees;
    private float timeBeforeChangingText;

    private void Awake() {
        driverSelectionDisplayPanel.SetActive(false);
        constructorSelectionDisplayPanel.SetActive(false);
        selectionTypeCanvas.SetActive(false);
        drafteeNumber1InputField.SetActive(false);
        drafteeNumber2InputField.SetActive(false);
        drafteeNumber3InputField.SetActive(false);
        drafteeNumber4InputField.SetActive(false);
        drafteePanel1.SetActive(false);
        drafteePanel2.SetActive(false);
        drafteePanel3.SetActive(false);
        drafteePanel4.SetActive(false);
        setUpText.text = "How Many Draftees?";
    }

    // public void GetDrafteeNames() {
    //     switch (drafteeNames.Count) {
    //         case 0:
    //             ChangeSetUpTextValue("Enter Draftee 1's Name");
    //             break;
    //         case 1:
    //             ChangeSetUpTextValue("Enter Draftee 2's Name");
    //             break;
    //     }
    // }
    
    public void ShowSelectionButtons() {
        selectionTypeCanvas.SetActive(true);
    }

    public void ShowDriverSelection() {
        if (constructorSelectionDisplayPanel.activeInHierarchy) {
            constructorSelectionDisplayPanel.SetActive(false);
        }
        driverSelectionDisplayPanel.SetActive(true);
        if (OnSelectionSwitch != null) {
            OnSelectionSwitch(this, EventArgs.Empty);
        }

    }

    public void ShowConstructorSelection() {
        if (driverSelectionDisplayPanel.activeInHierarchy) {
            driverSelectionDisplayPanel.SetActive(false);
        }

        constructorSelectionDisplayPanel.SetActive(true);
        if (OnSelectionSwitch != null) {
            OnSelectionSwitch(this, EventArgs.Empty);
        }
    }

    private void HideAmountOfDrafteeInputField() {
        amountOfDrafteesInputBox.SetActive(false);
    }

    public void SetAmountOfDraftees(int value) {
        amountOfDraftees = value;
        HideAmountOfDrafteeInputField();
        ShowDraftee1InputField();
    }

  
    private void ChangeSetUpTextValue(string text) {
        setUpText.text = text;
    }

    private void ShowDrafteePanel(GameObject panelToShow) {
        panelToShow.SetActive(true);
    }

    public void AddDrafteeNameToList(string value) {
        drafteeNames.Add(value);
        if (drafteeNumber1InputField.activeInHierarchy) {
            HideDraftee1InputField();
            ShowDraftee2InputField(); 
        }

        else if (drafteeNumber2InputField.activeInHierarchy) {
            HideDraftee2InputField();
            ShowDraftee3InputField();
        }

        else if (drafteeNumber3InputField.activeInHierarchy) {
            HideDraftee3InputField();
            ShowDraftee4InputField();
        }

        else if (drafteeNumber4InputField.activeInHierarchy) {
            HideDraftee4InputField();
        }
        
        Debug.Log(drafteeNames.Count);
        
    }


    private void ShowDraftee1InputField() {
        ChangeSetUpTextValue("Enter Draftee 1's Name");
        drafteeNumber1InputField.SetActive(true);
    }

    private void HideDraftee1InputField() {
        drafteeNumber1InputField.SetActive(false);
    }

    private void ShowDraftee2InputField() {
        ChangeSetUpTextValue("Enter Draftee 2's Name");
        drafteeNumber2InputField.SetActive(true);
    }
    private void HideDraftee2InputField() {
        drafteeNumber2InputField.SetActive(false);
    }

    private void ShowDraftee3InputField() {
        ChangeSetUpTextValue("Enter Draftee 3's Name");
        drafteeNumber3InputField.SetActive(true);
    }
    private void HideDraftee3InputField() {
        drafteeNumber3InputField.SetActive(false);
    }
    private void ShowDraftee4InputField() {
        ChangeSetUpTextValue("Enter Draftee 4's Name");
        drafteeNumber4InputField.SetActive(true);
    }
    
    private void HideDraftee4InputField() {
        drafteeNumber4InputField.SetActive(false);
    }




}
