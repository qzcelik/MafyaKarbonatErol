using UnityEngine;
using System.Collections;
using System;
using GoogleMobileAds.Api;

public class ReklamScript : MonoBehaviour
{
    private static ReklamScript instance = null;

    public string bannerID;
    public string interstitialID;

    public bool testMod = false;
    public string testDeviceID;

    private BannerView bannerReklam;
    private InterstitialAd interstitialReklam;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != instance)
        {
            Destroy(gameObject);
            return;
        }
    }
    public void calistir()
    {
        ReklamScript.InsterstitialGoster();
    }
    void Start()
    {
        if (this != instance)
            return;

        BannerReklamAl();
        InterstitialReklamAl();
       // ReklamScript.InsterstitialGoster();
    }

    void BannerReklamAl()
    {
        bannerReklam = new BannerView(bannerID, AdSize.SmartBanner, AdPosition.Top);

        AdRequest reklamiAl;
        if (testMod)
            reklamiAl = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator)
                                     .AddTestDevice(testDeviceID).Build();
        else
            reklamiAl = new AdRequest.Builder().Build();

        bannerReklam.LoadAd(reklamiAl);
        bannerReklam.Hide();
    }

    void InterstitialReklamAl()
    {
        if (interstitialReklam != null)
            interstitialReklam.Destroy();

        interstitialReklam = new InterstitialAd(interstitialID);
        interstitialReklam.OnAdClosed -= InterstitialDelegate;
        interstitialReklam.OnAdClosed += InterstitialDelegate;

        AdRequest reklamiAl;
        if (testMod)
            reklamiAl = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator)
                                     .AddTestDevice(testDeviceID).Build();
        else
            reklamiAl = new AdRequest.Builder().Build();

        interstitialReklam.LoadAd(reklamiAl);
    }

    public void InterstitialDelegate(object sender, EventArgs args)
    {
        InterstitialReklamAl();
    }

    /* void spawn()
     {
         /*if( GUI.Button( new Rect( Screen.width / 2 - 150, 0, 300, 150 ), "Banner Goster" ) )
              ReklamScript.BannerGoster();

          if( GUI.Button( new Rect( Screen.width / 2 - 150, 150, 300, 150 ), "Banner Gizle" ) )
              ReklamScript.BannerGizle();*/
    // if ( GUI.Button( new Rect( Screen.width / 2 - 150, 300, 300, 150 ), "Interstitial Goster" ) )

    //}

    public static void BannerGoster()
    {
        if (instance == null)
            return;

        if (instance.bannerReklam == null)
            instance.BannerReklamAl();

        instance.bannerReklam.Show();
    }

    public static void BannerGizle()
    {
        if (instance == null)
            return;

        if (instance.bannerReklam == null)
            return;

        instance.bannerReklam.Hide();
    }

    public static void InsterstitialGoster()
    {
        if (instance == null)
            return;

        if (instance.interstitialReklam == null)
            instance.InterstitialReklamAl();

        instance.StopCoroutine(instance.InsterstitialCoroutine());
        instance.StartCoroutine(instance.InsterstitialCoroutine());
    }

    IEnumerator InsterstitialCoroutine()
    {
        while (!interstitialReklam.IsLoaded())
            yield return null;

        interstitialReklam.Show();
    }
}