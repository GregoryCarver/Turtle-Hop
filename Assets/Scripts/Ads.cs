/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    public string bannerPlacement = "restartBannerAd";
    public bool testMode = true;

#if UNITY_IOS
    public const string gameID = "1234567";
#elif UNITY_ANDROID
    public const string gameID = "2876561";
#elif UNITY_EDITOR
    public const string gameID = "1111111";
#endif

    void Start()
    {
        Advertisement.Initialize(gameID, testMode);
        Advertisement.Banner.Load();
        //StartCoroutine(ShowBannerWhenReady());
    }

    /*IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady("banner"))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(bannerPlacement);
    }*/

/*    public void ShowAd()
    {
        Advertisement.Banner.Show(bannerPlacement);
    }

    public void HideAd()
    {
        Advertisement.Banner.Hide();
    }
}*/
