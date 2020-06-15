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
        if (GUILayout.Button("Change Color"))
            m_changeColorWithInput.ChangeColor();
        if (GUILayout.Button("Reset Color"))
            m_changeColorWithInput.ResetColor();
    }
}
