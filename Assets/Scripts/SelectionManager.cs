using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class SelectionManager : MonoBehaviour {
    
    private int whoIsSelecting = 0;
    private List<Draftee> draftees;
    [SerializeField] private UIManager uiManager;

    private string drafteeName;
    private void Awake() {
        uiManager.GetComponent<UIManager>();
    }

    private void GetFirstToDraftRandom() {
        whoIsSelecting = Random.Range(0, draftees.Count);
    }
    
    //Called from draft button. 
    public void GetNextWhoIsSelecting() {
        if (whoIsSelecting == 0) {
            whoIsSelecting = 1; 
        } else if (whoIsSelecting == 1) {
            whoIsSelecting = 2; 
        } else if (whoIsSelecting == 2) {
            whoIsSelecting = 3;
        } else {
            whoIsSelecting = 0; 
        }
    }

    public int GetWhoIsCurrentlySelecting() {
        return whoIsSelecting;
    }

    public string GetNameOfSelecting() {
        switch (whoIsSelecting) {
            case 0:
                drafteeName =  GetDrafteeAtIndex(0).GetDrafteeName();
                uiManager.SetDraftButtonText(drafteeName);
                break;
            case 1:
                drafteeName = GetDrafteeAtIndex(1).GetDrafteeName();
                uiManager.SetDraftButtonText(drafteeName);
                break;
            case 2:
                drafteeName = GetDrafteeAtIndex(2).GetDrafteeName();
                uiManager.SetDraftButtonText(drafteeName);
                break;
            case 3:
                drafteeName = GetDrafteeAtIndex(3).GetDrafteeName();
                uiManager.SetDraftButtonText(drafteeName);
                break;
        }

        return drafteeName;
    }

    private Draftee GenerateDraftee(string drafteeName) {
        return new Draftee(drafteeName);
    }
    
    
    public List<Draftee> GenerateDrafteesFromList() {
        draftees = new List<Draftee>();
        List<string> drafteeNames = uiManager.GetDrafteeNames();

        for (int i = 0; i < drafteeNames.Count; i++) {
            Draftee draftee = GenerateDraftee(drafteeNames[i]);
            draftees.Add(draftee);
        }

        GetFirstToDraftRandom();
        return draftees;
        
    }
    
    public List<Draftee> GetDrafteeList() {
        return draftees;
    }

    public Draftee GetDrafteeAtIndex(int index) {
        return draftees[index];
    }

}
