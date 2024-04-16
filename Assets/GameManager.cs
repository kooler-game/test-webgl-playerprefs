using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI setPrefsKey;
    public TextMeshProUGUI setPrefsValue;
    public TextMeshProUGUI getPrefsKey;

    public void OnClickSetPrefs()
    {
        Logger.instance.Log("> SetString " + setPrefsKey.text + " : " + setPrefsValue.text);
        PlayerPrefs.SetString(setPrefsKey.text, setPrefsValue.text);
        Logger.instance.Log("\n>> SetString Complete");
    }

    public void OnClickGetPrefs()
    {
        Logger.instance.Log("> GetString " + getPrefsKey.text);
        string value = PlayerPrefs.GetString(getPrefsKey.text);
        Logger.instance.Log("\n>>GetString " + getPrefsKey.text + " : " + value);
    }
}
