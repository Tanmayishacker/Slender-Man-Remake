using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchOffOn : MonoBehaviour
{
    [Tooltip("It the audio source for torch on off")]
    public AudioSource torchSound;

    [Tooltip("It is the spotlight(Torch) it self")]
    public GameObject torch;

    [SerializeField] bool isOn = false;
    bool safetySeconds;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (isOn == false && safetySeconds == false)
            {
                isOn = true;
                safetySeconds = true;
                torch.SetActive(true);
                torchSound.Play();
                StartCoroutine(FailSafe());
            }

            if (isOn == true && safetySeconds == false)
            {
                isOn = false;
                safetySeconds = true;
                torch.SetActive(false);
                torchSound.Play();
                StartCoroutine(FailSafe());
            }
        }
    }


    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(.25f);
        safetySeconds = false;
    }

}