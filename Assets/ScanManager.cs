using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ScanManager : MonoBehaviour
{
    // A reference to our Vedhalam GameObject.
    public GameObject vedhalam;
    
    // A reference to our Post-process Volume.
    public PostProcessVolume postProcessVolume;

    void Start()
    {
        // Make sure Vedhalam and the post-processing are off at the start.
        if (vedhalam != null)
        {
            vedhalam.SetActive(false);
        }
        if (postProcessVolume != null)
        {
            postProcessVolume.gameObject.SetActive(false);
        }
    }

    public void StartScan()
    {
        Debug.Log("Object scan initiated! The magic begins...");
        
        // Turn on Vedhalam.
        if (vedhalam != null)
        {
            vedhalam.SetActive(true);
        }

        // Turn on the post-processing effect.
        if (postProcessVolume != null)
        {
            postProcessVolume.gameObject.SetActive(true);
        }

        // We will add the story logic here in the next hour.
    }
}