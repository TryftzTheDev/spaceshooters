using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlinktiktok : MonoBehaviour
{
    public void Opentiktok()
    {
        Application.OpenURL("https://www.tiktok.com/@tryftzthedev?is_from_webapp=1&sender_device=pc&web_id6966346437904336389=");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
