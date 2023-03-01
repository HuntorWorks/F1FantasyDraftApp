using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    
    [SerializeField] private GameObject driverSelectionDisplayPanel;
    [SerializeField] private GameObject constructorSelectionDisplayPanel;
    public event EventHandler OnSelectionSwitch;

    private void Awake() {
        driverSelectionDisplayPanel.SetActive(false);
        constructorSelectionDisplayPanel.SetActive(false);
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
    
    
}
