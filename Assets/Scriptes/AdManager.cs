using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string androidGameId;
    [SerializeField] string iosGameId;

    public bool isTestingMode = false;

    string gameId;

    void Awake()
    {
        InitializeAds();
    }

    void InitializeAds()
    {


#if UNITY_IOS
        gameId = iosGameId;
#elif UNITY_ANDROID
        gameId = androidGameId;
#elif UNITY_EDITOR
        gameId = androidGameId;//for testing
#endif

        if (!Advertisement.isInitialized && Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, isTestingMode, this);//ONLY ONCE
        }

    }

    public void OnInitializationComplete()
    {
        print("Ads initialized!!");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        print("failed to initialize!!");
    }
}
