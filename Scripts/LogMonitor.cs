using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMonitor : MonoBehaviour
{
    private TextMesh textMesh;

    void Start()
    {
        textMesh = gameObject.GetComponent<TextMesh>();
    }

    void OnEnable()
    {
        Application.logMessageReceived += LogMessage;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        textMesh.text = message;
    }
}
