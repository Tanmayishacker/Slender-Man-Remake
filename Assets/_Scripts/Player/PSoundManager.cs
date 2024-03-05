using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSoundManager : MonoBehaviour
{
    [Tooltip("Contains the list of Sounds")]
    public AudioSource[] playerAudios;
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");


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
