using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlinkdisco : MonoBehaviour
{
    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.gg/fHy8R6fyc9");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
