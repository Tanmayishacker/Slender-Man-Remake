using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMapScript : MonoBehaviour
{
    public Transform playerLocationZX;

    private void LateUpdate() 
    {
        // Getting player position and pasting into the camers position. 
        Vector3 newCamposition = playerLocationZX.position;
        transform.position = newCamposition;

        // Taking players rotation on x and y axis.
        transform.rotation = Quaternion.Euler(90f, playerLocationZX.eulerAngles.y , 0);
    }      
}