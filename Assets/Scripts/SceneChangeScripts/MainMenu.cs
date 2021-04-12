using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private string homeMenu = "HomeMenu";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadHomeMenu()
    {
        SceneManager.LoadScene(homeMenu);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
