using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMapAccess : MonoBehaviour
{
    public GameObject buttonPress;
    [SerializeField] private Transform camTransformPoistion;
    [SerializeField] private float rayMaxDis;
    [SerializeField] private LayerMask mapRayLayer;
    private string objectToBeDestroyed = "Map";
    private RaycastHit hit;
    private Ray objectDestoryRay;

    [Header("Key To Press: ")]
    [SerializeField] private KeyCode keyToCollectMap ;
    void Update()
    {

        bool PaperChecker = Physics.Raycast(camTransformPoistion.position, camTransformPoistion.forward, rayMaxDis, mapRayLayer);

        objectDestoryRay = new Ray(camTransformPoistion.position, camTransformPoistion.forward * rayMaxDis);


        if(PaperChecker == true)
        {
            RayDestroyObject(objectDestoryRay);
        }
        else
        {
            buttonPress.SetActive(false);
        }

        
    }


    void RayDestroyObject(Ray rayRef)
    {
         buttonPress.SetActive(true);
            Debug.Log("Paper got");
            if (Input.GetKeyDown(keyToCollectMap) == true && hit.collider.tag == objectToBeDestroyed)
            {
                buttonPress.SetActive(false);
                Destroy(hit.transform);
                
            }
    }
}