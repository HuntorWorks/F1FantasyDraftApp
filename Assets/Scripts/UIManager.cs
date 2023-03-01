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
    [SerializeField] private GameObject draftButton;
    
    [SerializeField] private TextMeshProUGUI setUpText;

    private List<String> drafteeNames = new List<string>();
    [SerializeField] private GameObject drafteePanel1;
    [SerializeField] private GameObject drafteePanel2;
    [SerializeField] private GameObject drafteePanel3;
    [SerializeField] private GameObject drafteePanel4;

    private DrafteePanel draftee1;
    private DrafteePanel draftee2;
    private DrafteePanel draftee3;
    private DrafteePanel draftee4;

    [SerializeField] private SelectionManager selectionManager; 
    
    
    public event EventHandler OnSelectionSwitch; //Event that fires when there is a selection switch and subscribed to in 'RandomSelectionAtStart'

    private int amountOfDraftees;
    private float timeBeforeChangingText;

    private void Awake() {
        selectionManager.GetComponent<SelectionManager>();
        driverSelectionDisplayPanel.SetActive(false);
        constructorSelectionDisplayPanel.SetActive(false);
        selectionTypeCanvas.SetActive(false);
        HideDraftButton();
        HideDraftee1InputField();
        HideDraftee2InputField();
        HideDraftee3InputField();
        HideDraftee4InputField();
        drafteePanel1.SetActive(false);
        draftee1 = drafteePanel1.GetComponent<DrafteePanel>();
        drafteePanel2.SetActive(false);
        draftee2 = drafteePanel2.GetComponent<DrafteePanel>();
        drafteePanel3.SetActive(false);
        draftee3 = drafteePanel3.GetComponent<DrafteePanel>();
        drafteePanel4.SetActive(false);
        draftee4 = drafteePanel4.GetComponent<DrafteePanel>();
        setUpText.text = "How Many Draftees?";
    }
    
    public void ShowSelectionButtons() {
        selectionTypeCanvas.SetActive(true);
    }

    public void ShowDriverSelection() {
        if (constructorSelectionDisplayPanel.activeInHierarchy) {
            constructorSelectionDisplayPanel.SetActive(false);
        }
        driverSelectionDisplayPanel.SetActive(true);
        ShowDraftButton();
        
        if (OnSelectionSwitch != null) {
            OnSelectionSwitch(this, EventArgs.Empty);
        }

    }

    public void ShowConstructorSelection() {
        if (driverSelectionDisplayPanel.activeInHierarchy) {
            driverSelectionDisplayPanel.SetActive(false);
        }

        constructorSelectionDisplayPanel.SetActive(true);
        ShowDraftButton();
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

    private void ShowDraftButton() {
        draftButton.SetActive(true);
        SetDraftButtonText(selectionManager.GetNameOfSelecting());
    }

    private void SetDraftButtonText(string textToDisplay) {
        draftButton.GetComponentInChildren<TextMeshProUGUI>().text = textToDisplay;
    }

    private void HideDraftButton() {
        draftButton.SetActive(false);
    }
    private void HideSetUpText() {
        setUpText.gameObject.SetActive(false);
    }
    private void ChangeSetUpTextValue(string text) {
        setUpText.text = text;
    }

    private void ShowDrafteePanel(GameObject panelToShow) {
        panelToShow.SetActive(true);
    }

    private void SetDrafteePanelBaseValues(DrafteePanel draftee, int drafteeIndex) {
        draftee.SetDrafteeName(selectionManager.GetDrafteeAtIndex(drafteeIndex).GetDrafteeName());
        
    }

    public void AddDrafteeNameToList(string value) {
        drafteeNames.Add(value);
        selectionManager.GenerateDrafteesFromList();
        if (drafteeNumber1InputField.activeInHierarchy) {
            HideDraftee1InputField();
            ShowDrafteePanel(drafteePanel1);
            SetDrafteePanelBaseValues(draftee1, 0);
            ShowDraftee2InputField(); 
        }

        else if (drafteeNumber2InputField.activeInHierarchy) {
            HideDraftee2InputField();
            ShowDrafteePanel(drafteePanel2);
            SetDrafteePanelBaseValues(draftee2, 1);
            ShowDraftee3InputField();
        }

        else if (drafteeNumber3InputField.activeInHierarchy) {
            HideDraftee3InputField();
            ShowDrafteePanel(drafteePanel3);
            SetDrafteePanelBaseValues(draftee3, 2);
            ShowDraftee4InputField();
        }

        else if (drafteeNumber4InputField.activeInHierarchy) {
            HideDraftee4InputField();
            ShowDrafteePanel(drafteePanel4);
            SetDrafteePanelBaseValues(draftee4, 3);
            HideSetUpText();
            ShowSelectionButtons();
            
        }
    }

    public List<string> GetDrafteeNames() {
        return drafteeNames; 
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
