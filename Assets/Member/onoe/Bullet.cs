using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject mainCamera;
    GameObject planet;
    GameObject player;
    public float existFrame = 100;
    [Range(0.1f, 2.0f)]
    public float bulletSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        mainCamera = player.transform.Find("Main Camera").gameObject;
        planet = GameObject.Find("Planet");
        StartCoroutine(Movement());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Movement()
    {
        Debug.Log("started");
        for(int i = 0; i < existFrame; i++)
        {
            transform.RotateAround(planet.transform.position, mainCamera.transform.right, bulletSpeed);
            Debug.Log("spining");
            yield return null;
        }
        Destroy(this.gameObject);
    }
}
