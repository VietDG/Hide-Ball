//using Firebase.Analytics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalEventManager
{
    //public static Action<string, Parameter[]> EvtSendEvent;
    // public static Action<string, string> EvtUpdateUserProperties;

    #region Send Event Firebase
    //    #region Tracking Ads
    //    public static void SendEvtInterstitialShow(LocationInterstitialType position, string state)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //{
    //      new Parameter("position",position.ToString()),
    //      new Parameter("state",state)
    //};
    //        EvtSendEvent?.Invoke(Const.KEY_INTERSTITIAL_SHOW, parameter);
    //    }

    //    public static void SendEvtRewardedShow(LocationRewardType position, string state)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //        {
    //      new Parameter("position",position.ToString()),
    //      new Parameter("state",state)
    //};
    //        EvtSendEvent?.Invoke(Const.KEY_REWARDED_VIDEO_SHOW, parameter);
    //    }
    //    #endregion

    //    #region Tracking GamePlay
    //    public static void SendEvtLevelStar(int level, int step)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //  {
    //      new Parameter("id level", level.ToString()),
    //      new Parameter("id step", step.ToString())
    //  };
    //        EvtSendEvent?.Invoke(Const.KEY_LEVEL_START, parameter);
    //    }

    //    public static void SendEvtLevelFinish(int level, int step)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //        {
    //            new Parameter("id level",level.ToString()),
    //            new Parameter("id step",step.ToString())
    //        };
    //        EvtSendEvent?.Invoke(Const.KEY_LEVEL_FINISH, parameter);
    //        //  Debug.Log($"{Const.KEY_LEVEL_FINISH}: {level} --- step: {step}");
    //    }

    //    public static void SendEvtUnlockSkin(int idSkin)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //       {
    //            new Parameter("id skin",idSkin.ToString()),
    //       };
    //        EvtSendEvent?.Invoke(Const.KEY_UNLOCK_SKIN, parameter);
    //    }

    //    public static void SendEvtBackStep(int level, int step)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //       {
    //            new Parameter("id level",level.ToString()),
    //            new Parameter("id step",step.ToString())
    //       };
    //        EvtSendEvent?.Invoke(Const.KEY_BACK_STEP, parameter);
    //        // Debug.Log($"{Const.KEY_BACK_STEP}: {step}");
    //    }

    //    public static void SendEvtSkipLevel(int level)
    //    {
    //        Parameter[] parameter = new Parameter[]
    //       {
    //            new Parameter("id level",level.ToString()),
    //       };
    //        EvtSendEvent?.Invoke(Const.KEY_SKIP_LEVEL, parameter);
    //    }

    #endregion
    //    #endregion

    //    #region Send User Property
    //    public static int LevelReach
    //    {
    //        get => PlayerPrefs.GetInt(Const.KEY_LEVEL_REACH, 0);
    //        set => PlayerPrefs.SetInt(Const.KEY_LEVEL_REACH, value);
    //    }

    //    public static int DaysPlaying
    //    {
    //        get => PlayerPrefs.GetInt(Const.KEY_DAYS_PLAYING, 0);
    //        set => PlayerPrefs.SetInt(Const.KEY_DAYS_PLAYING, value);
    //    }

    //    public static int TotalSpentCoin
    //    {
    //        get => PlayerPrefs.GetInt(Const.KEY_TOTAL_SPENT, 0);
    //        set => PlayerPrefs.SetInt(Const.KEY_TOTAL_SPENT, value);
    //    }

    //    public static int TotalEarnCoin
    //    {
    //        get => PlayerPrefs.GetInt(Const.KEY_TOTAL_EARN, 0);
    //        set => PlayerPrefs.SetInt(Const.KEY_TOTAL_EARN, value);
    //    }

    //    public static void SendUserPropertyLevelReach(int value)
    //    {
    //        if (value <= LevelReach) return;
    //        LevelReach = value;
    //        EvtUpdateUserProperties?.Invoke(Const.KEY_LEVEL_REACH, LevelReach.ToString());
    //        // Debug.LogError($"Level Reach: {LevelReach}");
    //    }

    //    public static void SendUserPropertyDaysPlaying()
    //    {
    //        DaysPlaying++;
    //        EvtUpdateUserProperties?.Invoke(Const.KEY_DAYS_PLAYING, DaysPlaying.ToString());
    //        // Debug.LogError($"Days Playing: {DaysPlaying}");
    //    }

    //    public static void SendUserPropertyTotalSpentCoin(int value)
    //    {
    //        TotalSpentCoin += value;
    //        EvtUpdateUserProperties?.Invoke(Const.KEY_TOTAL_SPENT, TotalSpentCoin.ToString());
    //        //  Debug.LogError($"total spent coin: {TotalSpentCoin}");
    //    }

    //    public static void SendUserPropertyTotalEarnCoin(int value)
    //    {
    //        TotalEarnCoin += value;
    //        EvtUpdateUserProperties?.Invoke(Const.KEY_TOTAL_EARN, TotalEarnCoin.ToString());
    //        //  Debug.LogError($"total earn coin: {TotalEarnCoin}");
    //    }
    //    #endregion
}

public enum LocationInterstitialType
{
    None,
    Retry_Level,
    Win,
    Lose,
    Booster_Back,
    Drawing_Complete,
    Coloring_Complete
}

public enum LocationRewardType
{
    None,
    Booster_Skip,
    Daily_Reward,
    Unlock_skin,
    unlock_new_skin
}
