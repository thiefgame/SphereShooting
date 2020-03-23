using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlanet : MonoBehaviour
{
    Rigidbody rb;
    //public float autoTorque = 0.06f;
    //public float force = 0.049f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hrz = Input.GetAxis("Horizontal");
        float vrt = Input.GetAxis("Vertical");

        //rb.AddTorque(new Vector3(autoTorque, 0, 0));

        //Debug.Log("hrz:" + hrz + "/vrt:" + vrt);
        float ssH = 0.0f;
        float ssV = 0.0f;

        if (hrz != 0)
        {
            ssH = Mathf.Clamp(rb.angularVelocity.z + hrz, -1, 1);
            //rb.angularVelocity = new Vector3(0, 0, -ss);
        }
        if (vrt != 0)
        {
            ssV = Mathf.Clamp(1 + vrt * 0.9f, 0.1f, 1.9f);
            //rb.angularVelocity = new Vector3(-ss, 0, rb.angularVelocity.z);
        }
        else
        {
            ssV = 1;
        }

        rb.angularVelocity = new Vector3(-ssV, 0, -ssH);
    }
}
