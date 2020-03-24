using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitSphereScript : MonoBehaviour
{
    [SerializeField] GameObject SplitSphere;
    
    void Start()
    {
        StartCoroutine("SplitSphereInstantiate");
    }

    IEnumerator SplitSphereInstantiate()
    {
        yield return new WaitForSeconds(3.0f);

        Instantiate(SplitSphere, this.transform.position, Quaternion.identity);
    }
}
