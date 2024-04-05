using UnityEngine;
using UnityEngine.Video;
using System.Collections;

public class PlayerChecker : MonoBehaviour
{

    #region Common Variables
    [Header("Getting Playersinfo if the player hit this.")]
    public LayerMask playerMask;
    [Header("This is to play the static video.")]
    public GameObject staticVideoPlayer;

    [Header("This will have a single value.")]
    [SerializeField] private float singleRadii;
    [SerializeField] private float radiiMultiple;
    #endregion

    bool isInRange;

    void Update()
    {
        MainCheck();
    }

    void MainCheck()
    {
        bool bigFat = Physics.SphereCast(transform.position, singleRadii, Vector3.forward, out RaycastHit hitinfo, 0f,playerMask);

        if (bigFat)
        {
            StartCoroutine(PlayerInRange());



            if (isInRange && bigFat)
            {

            }
            else
            {
                isInRange = false;
            }
        }
        else
        {

        }
    }

    IEnumerator PlayerInRange()
    {
        yield return new WaitForSeconds(5f);
        isInRange = true;
    }

}
