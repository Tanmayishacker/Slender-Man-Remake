using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    [Tooltip("Contains the list of Sounds")]
    public AudioSource[] playerAudios;

    float hInput;
    float vInput;
    void Start()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
    }


    void Update()
    {
        if ((hInput > 0 || hInput < 0) || (vInput > 0 || vInput < 0))
        {
            Walk(true);
        }

        else
        {
            Walk(false);
        }
    }


    void Walk(bool isWalking)
    {
        playerAudios[0].enabled = isWalking;
    }

    void Sprint(bool isSprinting)
    {
        playerAudios[1].enabled = isSprinting;
    }
}
