using TMPro;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public TextMeshProUGUI loggingArea;

    public static Logger instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        if (loggingArea != null)
        {
            loggingArea.text = "";
            Log("Logger Initialized");
        }
    }

    public void Log(string message)
    {
        Debug.Log(message);
        AppendText(message);
    }

    public void AppendText(string message)
    {
        loggingArea.text = message + "\n" + loggingArea.text;
    }
}
