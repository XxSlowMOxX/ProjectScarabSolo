using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    private Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody spartanRb = this.GetComponentInParent<Rigidbody>();
        Vector3 wishedCamPos = new Vector3(0+Input.GetAxis("Horizontal")*2, 0- Input.GetAxis("Vertical")*2, 20);
        this.transform.localPosition = wishedCamPos;
    }
}
