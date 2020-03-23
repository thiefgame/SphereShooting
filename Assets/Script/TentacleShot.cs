using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleShot : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    //[SerializeField] GameObject planet;
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
            //transform.RotateAround(planet.transform.position, transform.forward, 1);
        }
        
    }

    IEnumerator Shot()
    {
        yield return new WaitForSeconds(2.0f);

        shot = true;
    }
}
