using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shamp()
    {
        SceneManager.LoadScene("SHAMP");

    }

    public void MainMenue()
    {
        SceneManager.LoadScene("MainMenue");
    }

    public void Survival()
    {
        SceneManager.LoadScene("survivalmode");
    }
    public void Horiz()
    {
        SceneManager.LoadScene("Horzandvert");
    }
    public void SurvivalModesToChoose()
    {
        SceneManager.LoadScene("survivalmodes");
    }
    public void Survivalreal()
    {
        SceneManager.LoadScene("survivalreal");
    }
    public void Timing()
    {
        SceneManager.LoadScene("survivalreal");
    }
    public void Defense()
    {
        SceneManager.LoadScene("defense");
    }
    public void Bonus()
    {
        SceneManager.LoadScene("bonus");
    }
    public void Clicking()
    {
        SceneManager.LoadScene("zombiesmode");
    }
    public void settings()
    {
        SceneManager.LoadScene("settings");
    }
}
