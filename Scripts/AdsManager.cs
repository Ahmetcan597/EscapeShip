using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
#if UNITY_ANDROID
    string game_ID = "5052955";
#else
    string game_ID = "5052954";
#endif

    void Start()
    {
        Advertisement.Initialize(game_ID);
    }

    public void PlayIntersitialAd()
    {
        if(Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
        }
    }

}
