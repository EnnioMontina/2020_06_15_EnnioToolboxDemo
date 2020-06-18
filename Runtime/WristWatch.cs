using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI; 
public class WristWatch : MonoBehaviour
{
    [Tooltip("Where the watch is supposed to be ")]
    [SerializeField]
    Transform m_wrist;
    [Tooltip("Link to the head")]
    [SerializeField]
    Transform m_head;
    [Tooltip("Angle max between Wrist(Up) look and Head(Forward) look")]
    [SerializeField]
    float m_angle = 25;

    [Header("Display Settings (Just link to the prefab)")]
    [SerializeField]
    Canvas m_canvas;

    [SerializeField]
    Text m_lastName;    
    [SerializeField]
    Text m_firstName;    
    [SerializeField]    
    Text m_surname;
    [SerializeField]
    Text m_studentJob;
    [SerializeField]
    Image m_image;
    [Header("Person data")]
    [SerializeField]
    CreditsData m_creditsData;

    public UnityEvent onWatch;
    public UnityEvent onStopWatch;

    bool isWatching = false;
    private void Start()
    {
        ResetWatchDisplay();
        m_canvas.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Vector3.Angle(m_wrist.up, m_head.position - m_wrist.position) < m_angle 
         && Vector3.Angle(m_head.forward, m_wrist.position - m_head.position) < m_angle)    
        {
            if (!isWatching)
            {
                onWatch.Invoke();
                m_canvas.gameObject.SetActive(true);
                isWatching = true;
            }
        }
        else
        {
            if (isWatching)
            {
                onStopWatch.Invoke();
                m_canvas.gameObject.SetActive(false);
                isWatching = false;
            }
        }
    }
    public void SetWatchDisplayData(CreditsData newData)
    {
        m_creditsData = newData;
        ResetWatchDisplay();
    }
    public void ResetWatchDisplay()
    {
        m_lastName.text = m_creditsData.m_studentName;
        m_firstName.text = m_creditsData.m_studentFirstName;
        m_surname.text = m_creditsData.m_Surname;
        m_studentJob.text = m_creditsData.studentJob.ToString();
        m_image.sprite = m_creditsData.m_profilePicture;
    }

}
