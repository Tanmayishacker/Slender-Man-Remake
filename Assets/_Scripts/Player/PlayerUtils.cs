using UnityEngine;
using System.Collections;

public class PlayerUtils : MonoBehaviour
{
    #region Torch Variables
    [Tooltip("Put Your Audio Source Here.")]
    public AudioSource torchSound;

    [Tooltip("Put the gameobject torch Here.")]
    public GameObject torch;

    [SerializeField] bool isOn = false;
    bool safetySeconds;

    #endregion

    #region Map Variables

    [Tooltip("Put the 'Press F' here")]
    public GameObject collectingInstuction;

    private float distanceCheckerRay = 10f;
    private LayerMask cInstructionLayer;

    #endregion

    #region Main Game Menu activating variables

    public GameObject[] UIs;
    [SerializeField] KeyCode escKey;

    #endregion


    private void Update()
    {
        TorchController();
        MapCollect();

        if (Input.GetKeyDown(escKey))
        {
            Disabling();
            Time.timeScale = 0f;
        }
        else
        {
            
        }

    }

    // Torch Controller (On/Off) methods.
    void TorchController()
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
        yield return new WaitForSeconds(.5f);
        safetySeconds = false;
    }

    // Map Collection method.
    void MapCollect()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distanceCheckerRay,cInstructionLayer))
        {
            var map = hit.transform;

            if (Input.GetButtonDown("f"))
            {
                GameObject.Destroy(collectingInstuction);
            }
            
        }


    }


    // For disabling all the UIs
    private void Disabling()
    {
        foreach (var UIset in UIs)
        {
            UIset.SetActive(false);
        }
    }

    public void Enableing()
    {
        foreach (var UIset in UIs)
        {
            UIset.SetActive(true);
        }
    }


}