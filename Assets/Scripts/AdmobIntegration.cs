using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobIntegration : MonoBehaviour {

    InterstitialAd interstitial;
    AdRequest request;

    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize("");  //Admob ID to be entered here.
        RequestInterstitial();
    }

    void FixedUpdate()
    {
        if (GameManager.gameHasEnded == true)
        {
            if (interstitial.IsLoaded())
            {
                interstitial.Show();
            }
            else
            {
                interstitial.LoadAd(request);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                interstitial.Destroy();
            }
        }
    }

    private void RequestInterstitial()
    { 
        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd("");  //Admob ID to be entered here.

        // Create an empty ad request.
        request = new AdRequest.Builder()
            .Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

}
