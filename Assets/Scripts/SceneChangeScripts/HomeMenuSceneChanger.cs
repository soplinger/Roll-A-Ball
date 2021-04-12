using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeMenuSceneChanger : MonoBehaviour
{

    public TextMeshProUGUI countText;

    private string levelSelectionScene = "LevelSelection";
    private string shopScene = "ShopMenu";
    private string exitScene = "MainMenu";

    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetCountText()
    {
        countText.text = "Count: " + ApplicationData.totalCoinCount.ToString();
    }

    public void loadLevelSelection()
    {
        SceneManager.LoadScene(levelSelectionScene);
    }

    public void loadStoreScene()
    {
        SceneManager.LoadScene(shopScene);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(exitScene);
    }
}
