using UnityEngine;

public class MinMapScript : MonoBehaviour
{
    public Transform playerLocationZX;

    private void LateUpdate() 
    {
        // Getting player position and pasting into the camers position. 
        Vector3 newCameraPosition = new Vector3(playerLocationZX.position.x, transform.position.y, playerLocationZX.position.z);
        transform.position = newCameraPosition;

        // Taking players rotation on x and y axis.
        transform.rotation = Quaternion.Euler(90f, playerLocationZX.eulerAngles.y , 0);
    }      
}