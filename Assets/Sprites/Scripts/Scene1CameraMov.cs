using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1CameraMov : MonoBehaviour
{
    // Update is called once per frame
    public Transform camera;
    public Transform ball;
    public bool enable = false;
    float movSpeed = 2.7f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject.Find("Circle").GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            enable = true;
        }
        if (enable){
            Debug.Log("enable status: " + enable);
            camera.transform.position += new Vector3(movSpeed * Time.deltaTime, 0, 0);
        }
    }
}
