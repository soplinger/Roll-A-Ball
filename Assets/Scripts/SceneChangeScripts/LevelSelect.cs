using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelect : MonoBehaviour
{

    public TextMeshProUGUI countText;
    public TextMeshProUGUI level1CoinText;
    public TextMeshProUGUI level1TimerText;
    public TextMeshProUGUI level2CoinText;
    public TextMeshProUGUI level2TimerText;

    private string levelSelect1 = "MiniGame";
    private string levelSelect2 = "Level2";
    private string HomeMenu = "HomeMenu";
    // Start is called before the first frame update
    void Start()
    {
        SetCountText();

        if (ApplicationData.playedOne == true)
        {
            if (ApplicationData.levelOneCoinsGathered <= ApplicationData.coinCount)
            {
                ApplicationData.levelOneCoinsGathered = ApplicationData.coinCount;
            }
            
            if (ApplicationData.levelOneCompletionTime >= ApplicationData.levelTime)
            {
                print(ApplicationData.levelTime);
                ApplicationData.levelOneCompletionTime = ApplicationData.levelTime;
            }

            ApplicationData.playedOne = false;

        }

        if (ApplicationData.playedTwo == true)
        {
            if (ApplicationData.levelTwoCoinsGathered <= ApplicationData.coinCount)
            {
                ApplicationData.levelTwoCoinsGathered = ApplicationData.coinCount;
            }

            if (ApplicationData.levelTwoCompletionTime >= ApplicationData.levelTime)
            {
                ApplicationData.levelTwoCompletionTime = ApplicationData.levelTime;
            }

            ApplicationData.playedTwo = false;

        }

        SetHighScores();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetCountText()
    {
        countText.text = "Count: " + ApplicationData.totalCoinCount.ToString();
    }

    void SetHighScores()
    {
        level1CoinText.text = "Best Coins: " + ApplicationData.levelOneCoinsGathered.ToString() + " / 12";
        
        if (ApplicationData.levelOneCompletionTime == 1000)
        {
            level1TimerText.text = "Best Time: ---";
        }
        else
        {
            level1TimerText.text = "Best Time: " + ApplicationData.levelOneCompletionTime.ToString("F2");
        }
        
        level2CoinText.text = "Best Coins: " + ApplicationData.levelTwoCoinsGathered.ToString() + " / 9";
        
        if (ApplicationData.levelTwoCompletionTime == 1000)
        {
            level2TimerText.text = "Best Time: ---";
        }
        else
        {
            level2TimerText.text = "Best Time: " + ApplicationData.levelTwoCompletionTime.ToString("F2");
        }
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene(levelSelect1);
        ApplicationData.playedOne = true;
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene(levelSelect2);
        ApplicationData.playedTwo = true;
    }

    public void loadHomeMenu()
    {
        SceneManager.LoadScene(HomeMenu);
    }
}
