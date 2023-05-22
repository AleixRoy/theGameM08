using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumen : MonoBehaviour
{

    public AudioMixer Au;
    Resolution[] resolutions;

    public Dropdown rDp;
    void Start() {

        resolutions = Screen.resolutions;
        rDp.ClearOptions();
        List<string> options = new List<string>();
        
        int currentresolI = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentresolI = i;
            }
        }
        rDp.AddOptions(options);
        rDp.value = currentresolI;
        rDp.RefreshShownValue();
        
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume (float volume) {
        Au.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }


}