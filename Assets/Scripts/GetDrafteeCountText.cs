using System;
using UnityEngine;
using TMPro;
public class GetDrafteeCountText : MonoBehaviour {
    
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private UIManager uiManager;

    private void Start() {
        inputField.onEndEdit.AddListener(delegate { OnEndEdit(); });
            
    }

    private void OnEndEdit() {
       uiManager.SetAmountOfDraftees(Int32.Parse(inputField.text));
    }
}
