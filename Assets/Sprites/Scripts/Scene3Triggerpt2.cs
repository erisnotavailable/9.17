using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Triggerpt2 : MonoBehaviour
{
    public Transform camera;
    float movSpeed = -0.02f;
    public bool enable = false;
    void OnTriggerEnter2D(Collider2D act){
        Debug.Log("Scene3Triggerpt2: triggered");
        GameObject.Find("Switch").GetComponent<PolygonCollider2D>().enabled = false;
        GameObject.Find("Switch").GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        GameObject.Find("Fence").GetComponent<BoxCollider2D>().enabled = false;
        enable = true;
    }

    void Update() {
        if(enable){
            camera.transform.position += new Vector3(movSpeed, 0, 0);
        }
    }
}
