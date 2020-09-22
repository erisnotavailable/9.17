using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Trigger : MonoBehaviour
{
    public Transform camera;
    public Transform cameraFocusTarget = null;
    public bool enable = false;
    Vector3 difference;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D act){
        GameObject.Find("Main Camera").GetComponent<Scene1CameraMov>().enable = false;
        enable = true;
        cameraFocusTarget = act.transform;
        difference = new Vector3(camera.transform.position.x - act.transform.position.x, 
            camera.transform.position.y - act.transform.position.y, -10f);
    }

    void Update() {
        if (enable) {
            camera.position = cameraFocusTarget.position + difference;
        }
    }
}
