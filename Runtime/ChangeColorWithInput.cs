using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWithInput : MonoBehaviour
{
    public Renderer m_targetRenderer;
    public KeyCode m_inputKey = KeyCode.Space;

    float m_colorH = 0;
    void Update()
    {
        if (Input.GetKeyDown(m_inputKey))
            AddToColorChart();
    }
    public void AddToColorChart()
    {
        m_colorH = (m_colorH + 0.01f)%1;
        if (m_targetRenderer != null)
            m_targetRenderer.sharedMaterial.color = Color.HSVToRGB(m_colorH, 1, 1);
    }
    public void RandomColor()
    {
        if (m_targetRenderer != null)
            m_targetRenderer.sharedMaterial.color = Color.HSVToRGB(Random.Range(0,1f), 1, 1);
    }
    public void ResetColor()
    {
        if (m_targetRenderer != null)
            m_targetRenderer.sharedMaterial.color = new Color(1, 1, 1, 1);

    }

}
