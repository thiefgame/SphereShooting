using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    GameObject planet;
    GameObject player;
    Vector3 axis;
    public float existDistance = 100;
    [Range(0.1f, 2.0f)]
    public float bulletSpeed = 1.0f;

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
        for(int i = 0; i < existDistance / bulletSpeed; i++)
        {
            transform.RotateAround(planet.transform.position, axis, bulletSpeed);
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
