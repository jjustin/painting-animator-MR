using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using TMPro;

public class GlobalVars : MonoBehaviour
{
#if UNITY_EDITOR
    private static string api_url = "localhost:5000";
    private static int match_threshold = 10;
#else
    private static string api_url = "192.168.1.198:5000";
    private static int match_threshold = 50;
#endif
    public static string API_URL
    {
        get { return "http://" + api_url; }
        set { api_url = value; }
    }
    public static int MATCH_THRESHOLD
    {
        get { return match_threshold; }
        set { match_threshold = value; }
    }
    public static bool API_URL_READY = false;

    [SerializeField]
    MixedRealityKeyboard keyboard;

    public TextMeshPro ipText;

    // Start is called before the first frame update
    void Start()
    {
        keyboard = this.GetComponent<MixedRealityKeyboard>();
        showKeyboard();
        Update();

#if UNITY_EDITOR
        inputDone();
        return;
#endif
    }

    private void Update()
    {
        ipText.text = keyboard.Text;
    }

    public void showKeyboard()
    {
        keyboard.ShowKeyboard(api_url, false);
    }

    public void inputDone()
    {
        API_URL = keyboard.Text;
        API_URL_READY = true;
        keyboard.HideKeyboard();
        Destroy(ipText);
        Destroy(this);
    }

}
