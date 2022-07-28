using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlink : MonoBehaviour
{
    public void OpenYouTube() {
        Application.OpenURL("https://www.youtube.com/channel/UC0Z4g8P4mzsPgXo9zfND9sw");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
