using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitSphereScript : MonoBehaviour
{
    public GameObject SplitSphere;

    void Start()
    {
        StartCoroutine("DestroyTentacl");
    }

    IEnumerator DestroyTentacl()
    {
        yield return new WaitForSeconds(3.0f);

        Instantiate(SplitSphere, this.transform.position, Quaternion.identity);

        Destroy(GameObject.Find("Tentacls"));
        Destroy(GameObject.Find("Tentacls(Clone)"));
    }
}
