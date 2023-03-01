using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomSelectionAtStart : MonoBehaviour {

    public UnityEvent OnEnableEvent;
    public void OnEnable() {
        if (OnEnableEvent != null) {
            OnEnableEvent.Invoke();
        }
    }
}
