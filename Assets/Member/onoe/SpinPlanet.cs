using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlanet : MonoBehaviour
{
    Rigidbody rb;

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

        //Debug.Log("hrz:" + hrz + "/vrt:" + vrt);
        float ssH = 0.0f;
        float ssV = 0.0f;

        if (hrz != 0)
        {
            ssH = Mathf.Clamp(rb.angularVelocity.z + hrz, -1, 1);
        }
        if (vrt != 0)
        {
            ssV = Mathf.Clamp(1 + vrt * 0.9f, 0.1f, 1.9f);
        }
        else
        {
            ssV = 1;
        }

        rb.angularVelocity = new Vector3(-ssV, 0, -ssH);
    }
}
