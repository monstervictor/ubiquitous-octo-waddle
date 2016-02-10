using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Canvas c_quit;
    public Canvas c_main;
    public Button b_start;
    public Button b_exit;
    public Button b_continue;
    public string firstLevelName;
    // Use this for initialization
    void Start()
    {
        if (c_main == null) c_main = GetComponentInParent<Canvas>();
        if (c_main == null) Debug.LogError("canvasNotSelected");
        c_quit.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExitPress()
    {
        c_quit.enabled = true;
        c_main.enabled = false;
    }

    public void NoPress()
    {
        c_quit.enabled = false;
        c_main.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(firstLevelName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
