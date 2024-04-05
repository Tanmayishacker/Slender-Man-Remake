using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;

public class EntryLevelUI : MonoBehaviour
{
    // Access to all the canvases.
    public GameObject startMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;

    // Access to all the external things for settings menu.//


    // Getting Volume.
    public Volume postProcessingVolume;
    public VolumeProfile postProfile;

    private MotionBlur motionBlurPP;
    private Bloom bloomPP;

    // Getting audio to controll from script.
    public AudioMixer audioMixer;

    private void Start()
    {
        postProcessingVolume.profile.TryGet(out motionBlurPP);
        postProcessingVolume.profile.TryGet(out bloomPP);
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // This of code is for the start menu.
    public void StartMenuToSettings()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void SettingsToStartMenu()
    {
        settingsMenu.SetActive(false);
        startMenu.SetActive(true);

    }
    //-----------------------------------------------//

    // This of is for the credits menu.
    public void StartMenuToCredits()
    {
        startMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void CreditsToStartMenu()
    {
        creditsMenu.SetActive(false);
        startMenu.SetActive(true);

    }
    //-----------------------------------------------//

    // This of code is for the settings menu.
    public void startToSettingMenu() 
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void settingsToStartMenu()
    {
        settingsMenu.SetActive(false);
        startMenu.SetActive(true);
    }

    //------------------------------------------------//

    // This of code is for quiting the menu.
    public void ApplicationQuitter()
    {
        Debug.Log("You Are Done Quitting");
        Application.Quit();
    }
    

    // Methods for Settings below.
    public void MotionBlurToggler(bool motionblur)
    {
        motionBlurPP.active = motionblur;
    }

    public void PPBloom(bool bloom)
    {
        bloomPP.active = bloom;
    }

    public void VolumeSlider(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }


}