using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopSelection : MonoBehaviour
{

    public TextMeshProUGUI countText;

    private string HomeMenu = "HomeMenu";
    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShopPurchaseOne()
    {
        if (ApplicationData.totalCoinCount >= 10)
        {
            print("Purchased Successfully!");
            ApplicationData.totalCoinCount = ApplicationData.totalCoinCount - 10;
            SetCountText();
        }

        else
        {
            print("Not Enough Coins!");
        }
    }

    public void ShopPurchaseTwo()
    {
        if (ApplicationData.totalCoinCount >= 20)
        {
            print("Purchased Successfully!");
            ApplicationData.totalCoinCount = ApplicationData.totalCoinCount - 20;
            SetCountText();
        }

        else
        {
            print("Not Enough Coins!");
        }
    }

    public void ShopPurchaseThree()
    {
        if (ApplicationData.totalCoinCount >= 30)
        {
            print("Purchased Successfully!");
            ApplicationData.coinCount = ApplicationData.totalCoinCount - 30;
            SetCountText();
        }

        else
        {
            print("Not Enough Coins!");
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + ApplicationData.totalCoinCount.ToString();
    }

    public void loadHomeMenu()
    {
        SceneManager.LoadScene(HomeMenu);
    }
}
