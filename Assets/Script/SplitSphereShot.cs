using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitSphereShot : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;

    void FixedUpdate()
    {
        transform.position += transform.forward * speed;
    }


}
