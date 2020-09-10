using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 toVelocity;
    public float baseSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        toVelocity.x = Input.GetAxis("Horizontal");
        toVelocity.z = Input.GetAxis("Vertical");
        Vector3.ClampMagnitude(toVelocity, 1.0f);
    }
    private void FixedUpdate()
    {
        rb.velocity = toVelocity * baseSpeed *-1;
    }
}
