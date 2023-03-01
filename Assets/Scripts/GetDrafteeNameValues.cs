using TMPro;
using UnityEngine;

public class GetDrafteeNameValues : MonoBehaviour {
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private UIManager uiManager;

    private void Start() {
        inputField.onEndEdit.AddListener(delegate { OnEndEdit(); });
    }

    private void OnEndEdit() {
        uiManager.AddDrafteeNameToList(inputField.text);
    }
}
