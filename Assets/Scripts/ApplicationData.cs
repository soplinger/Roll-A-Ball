using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ApplicationData
{
    //temp variables per level
    public static int coinCount;
    public static float levelTime;

    //flags for level played

    public static bool playedOne;
    public static bool playedTwo;

    //persistent data per session
    public static int totalCoinCount;
    public static int levelOneCoinsGathered;
    public static float levelOneCompletionTime = 1000;
    public static int levelTwoCoinsGathered;
    public static float levelTwoCompletionTime = 1000;
}
