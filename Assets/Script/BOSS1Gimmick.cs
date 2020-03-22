using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS1Gimmick : MonoBehaviour
{
    [SerializeField] GameObject Tentacls;
    GameObject Obj;
 
    void Start()
    {
        StartCoroutine("TentaclsInstantiate");
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 1, 0));
    }

    IEnumerator TentaclsInstantiate()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Obj = Instantiate(Tentacls, this.transform.position, Quaternion.identity);
            Obj.transform.parent = this.transform;
        }

    }
}
