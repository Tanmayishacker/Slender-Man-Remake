using UnityEngine;

public class PlayerMapAccess : MonoBehaviour
{
    public GameObject buttonPress;
    [SerializeField] private float rayMaxDis;
    [SerializeField] private LayerMask mapRayLayer;
    [SerializeField] private Transform camTransformPoistion;

    // Private Variables not exposed to editor.
    private RaycastHit hit;

    [Header("Key To Press: ")]
    [SerializeField] private KeyCode keyToCollectMap ;



    void Update()
    {

        bool PaperChecker = Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayMaxDis,mapRayLayer);

        if(PaperChecker)
        {
            buttonPress.SetActive(true);
            RayDestroyObject();
        }
        else
        {
            buttonPress.SetActive(false);
        }

        
    }


    void RayDestroyObject()
    {
        Debug.Log("Paper got");

        if (Input.GetKeyDown(keyToCollectMap))
        {
            buttonPress.SetActive(false);
            Destroy(hit.transform.gameObject);
        }


    }
}