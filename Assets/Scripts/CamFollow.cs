using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public float followModifier;

    private Rigidbody rb;
    private Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
        rb = this.GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 wishedCamPos = new Vector3(0 + Input.GetAxis("Horizontal") * followModifier, 0 - Input.GetAxis("Vertical") * followModifier, 20);
        this.transform.localPosition = wishedCamPos;
        
    }
}
