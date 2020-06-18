using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(WristWatch))]
public class WristWatchEditor : Editor
{
    WristWatch m_wristWatch;

    private void OnEnable()
    {
        m_wristWatch = (WristWatch)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Reset Display"))
            m_wristWatch.ResetWatchDisplay();
    }
}
