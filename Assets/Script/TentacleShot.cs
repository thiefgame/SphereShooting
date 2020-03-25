using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleShot : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    bool shot;

    void Start()
    {
        shot = false;
        StartCoroutine("Shot");
    }

    private void Update()
    {
        if (shot == true)
        {
            transform.position += transform.forward * speed;
        }
        
    }

    IEnumerator Shot()
    {
        yield return new WaitForSeconds(2.0f);

        shot = true;
    }
}
