using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitSphereShot : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    [SerializeField] GameObject Empty;
    private void Start()
    {
       StartCoroutine("DestroySplitSphere");
    }
    

    void FixedUpdate()
    {
        transform.position += transform.forward * speed;
    }

    IEnumerator DestroySplitSphere()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this.Empty);
    }
}
