using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(ChangeColorWithInput))]
public class ChangeColorWithInputEditor : Editor
{
    ChangeColorWithInput m_changeColorWithInput;

    private void OnEnable()
    {
        m_changeColorWithInput = (ChangeColorWithInput)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("AddColorChart"))
            m_changeColorWithInput.AddToColorChart();
        if (GUILayout.Button("Random Color"))
            m_changeColorWithInput.RandomColor();
        if (GUILayout.Button("Reset Color"))
            m_changeColorWithInput.ResetColor();
    }

}
