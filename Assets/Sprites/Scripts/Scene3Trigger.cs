using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Trigger : MonoBehaviour
{
    public Transform camera;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D act){
        Debug.Log("Entered");
        GameObject.Find("TriggerScene2").GetComponent<Scene2Trigger>().enable = false;
    }
}
