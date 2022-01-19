using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class InputManager : MonoBehaviour
{
    [SerializeField]
    GameObject arObj;

    [SerializeField]
    Camera arCam;

    [SerializeField]
    ARRaycastManager raycastManager;

    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = arCam.ScreenPointToRay(Input.mousePosition);
            if(raycastManager.Raycast(ray,hits))
            {
                Pose pose = hits[0].pose;
                Instantiate(arObj,pose.position,pose.rotation);
            }
        }
        
    }
}
