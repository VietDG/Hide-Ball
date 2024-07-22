using System;
using UnityEngine;

public static class ActionEvent
{
    #region Game Play
    //   public static Action<StateGame> OnChangeStateGame;
    //  public static Action<StateScene> OnChangeScene;
    //  public static Action<ModeGameType> OnChangeModeGame;
    public static Action OnPlayGame;
    public static Action OnExitGamePlay;
    public static Action<int> OnInitGamePlay;
    //  public static Action<PaintItem> OnChangePaint;
    public static Action<float> OnRotateCam;
    /// <summary>
    /// Nail
    /// </summary>
   // public static Action<NailController> OnChangeNail;
    #endregion
    /// <summary>
    /// Select Skin
    /// </summary>
    public static Action<Color> OnChangSkinColor;
    public static Action<Sprite> OnChangeSkinBG;

    #region Booster
    public static Action OnUseBoosterBackStep;
    public static Action OnUpdateBoosterBackStep;
    public static Action OnUseBoosterSkip;
    public static Action onUpdateBoosterSkip;
    #endregion

    #region My Toast
    public static Action<string> OnShowToast;
    public static Action OnShowLoadingAds;
    #endregion

    #region Network
    public static Action OnConnectedNetWork;
    #endregion

    #region Tutorial
    public static Action<bool> OnTutHowToPlay;
    public static Action OnTutUseHint;
    public static Action OnShowTutShop_1;
    public static Action OnHideTutShop_1;
    public static Action OnShowTutHint;
    public static Action OnHideTutHint;
    #endregion

    #region Ads
    public static Action OnRemoveAds;
    //  public static Action<BannerType> OnShowBanner;
    public static Action OnHideBanner;
    #endregion

    #region CUrrentcy
    public static Action<int, int> OnSpendCoin;
    public static Action<int, int> OnEarnCoin;
    public static Action OnUpdateCoinComplete;
    #endregion

    #region Shop
    public static Action OnChangeSkinEquip;
    public static Action<int> OnSelectSkin;
    #endregion
}
