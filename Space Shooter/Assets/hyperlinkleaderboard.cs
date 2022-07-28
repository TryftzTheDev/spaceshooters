using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlinkleaderboard : MonoBehaviour
{
    public void Leaderboard()
    {
        Application.OpenURL("https://leaderboard.tryftz.repl.co/");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
