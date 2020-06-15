using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWithInput : MonoBehaviour
{
    public Renderer m_targetRenderer;
    public KeyCode m_inputKey = KeyCode.Space;
    void Update()
    {
        if (Input.GetKeyDown(m_inputKey))
            ChangeColor();
    }
    public void ChangeColor()
    {
        if (m_targetRenderer != null)
            m_targetRenderer.sharedMaterial.color = Color.HSVToRGB(Random.Range(0, 1f), 1, 1);
    }
    public void ResetColor()
    {
        if (m_targetRenderer != null)
            m_targetRenderer.sharedMaterial.color = new Color(1, 1, 1, 1);

    }

}
