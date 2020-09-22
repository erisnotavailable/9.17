using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Trigger : MonoBehaviour
{
    public Transform camera;
    public Transform cameraFocusTarget;
    public bool enable = false;
    Vector3 difference;
    void OnTriggerEnter2D(Collider2D act){
        Debug.Log("Scene4Trigger: triggered");
        GameObject.Find("TriggerScene3pt2").GetComponent<Scene3Triggerpt2>().enable = false;
        enable = true;
        cameraFocusTarget = act.transform;
        difference = new Vector3(camera.transform.position.x - act.transform.position.x, 
            camera.transform.position.y - act.transform.position.y , -10f);
    }

    void Update() {
        if(enable){
            camera.position = cameraFocusTarget.position + difference;
        }
    }
}
