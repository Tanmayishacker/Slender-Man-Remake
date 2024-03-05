using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class MainGameLoader : MonoBehaviour
{
    // Access to all the canvases.
    public GameObject startMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;

    // Access to all the external things for settings menu.//


    // Getting Volume.
    public Volume postProcessingVolume;
    public VolumeProfile postProfile;

    // TODO: To get volume and start method.
    private MotionBlur motionBlur;
    private Bloom bloom;

    // Getting audio to controll from script.
    public AudioMixer audioMixer;

    private void Start()
    {
        postProcessingVolume.profile.TryGet(out motionBlur);
        postProcessingVolume.profile.TryGet(out bloom);
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
        motionBlur.active = motionblur;
    }

    public void PPBloom(bool bolom)
    {
        bloom.active = bolom;
    }

    public void VolumeSlider(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }


}