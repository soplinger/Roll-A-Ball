using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private string levelSelectionScene = "LevelSelection";
    private string homeMenuScene = "HomeMenu";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadLevelSelection()
    {
        SceneManager.LoadScene(levelSelectionScene);
    }

    public void loadHomeMenu()
    {
        SceneManager.LoadScene(homeMenuScene);
    }

}
