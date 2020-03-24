using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    GameObject planet;
    GameObject player;
    Vector3 axis;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        planet = GameObject.Find("Planet");
        axis = Vector3.Cross(transform.position - planet.transform.position, player.transform.position - planet.transform.position);
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Movement()
    {
        for(int i = 0; i < 100; i++)
        {
            transform.RotateAround(planet.transform.position, axis, 1);
            yield return null;
        }
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
