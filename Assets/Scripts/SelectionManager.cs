using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SelectionManager : MonoBehaviour {
    
    private int whoIsSelecting;
    private List<Draftee> draftees;
    [SerializeField] private UIManager uiManager;

    private void Awake() {
        uiManager.GetComponent<UIManager>();
    }

    public int GetWhoIsSelecting() {
        return whoIsSelecting;
    }

    public Draftee GenerateDraftee(string drafteeName) {
        return new Draftee(drafteeName);
    }
    
    
    public List<Draftee> GenerateDrafteesFromList() {
        draftees = new List<Draftee>();
        List<string> drafteeNames = uiManager.GetDrafteeNames();

        for (int i = 0; i < drafteeNames.Count; i++) {
            Draftee draftee = GenerateDraftee(drafteeNames[i]);
            draftees.Add(draftee);
        }

        return draftees;
    }
    
    public List<Draftee> GetDrafteeList() {
        return draftees;
    }

    public Draftee GetDratfeeAtIndex(int index) {
        Debug.Log(draftees[index].GetDrafteeName());
        return draftees[index];
    }

}
