using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentaclsDestroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("DestroyTentacl");
    }

    IEnumerator DestroyTentacl()
    {
        yield return new WaitForSeconds(3.0f);

        Destroy(this.gameObject);

    }
}
