using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    GameObject planet;
    GameObject mainCamera;
    public GameObject bullet;
    Transform hana;
    bool movin = false;
    EnemyGenerator eG;

    public enum Movement
    {
        YuraYura,
        Tombo,
        GuruGuru,
        GuruGuru2,
        Random
    }
    [SerializeField] Movement movement = Movement.YuraYura;

    // Start is called before the first frame update
    void Start()
    {
        planet = transform.parent.gameObject;
        eG = planet.GetComponent<EnemyGenerator>();
        mainCamera = GameObject.Find("Player").transform.Find("Main Camera").gameObject;
        hana = transform.Find("Hana");
        if (movement == Movement.Random)
        {
            movement = (Movement)Random.Range(0, 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (movement)
        {
            case Movement.YuraYura:
                if (!movin) { movin = true; StartCoroutine(YuraYura()); }
                break;
            case Movement.GuruGuru:
                transform.RotateAround(planet.transform.position, planet.transform.forward, 1);
                break;
            case Movement.GuruGuru2:
                transform.RotateAround(planet.transform.position, mainCamera.transform.up, 1);
                break;
            case Movement.Tombo:
                transform.RotateAround(planet.transform.position, mainCamera.transform.right, planet.GetComponent<SpinPlanet>().DeltaSpin);
                if (!movin) { movin = true; StartCoroutine(Tombo()); }
                break;
        }
    }

    IEnumerator YuraYura()
    {
        for (int i = 0; i < 15; i++)
        {
            //transform.RotateAround(planet.transform.position, mainCamera.transform.up, 4 - i / 4);
            transform.RotateAround(planet.transform.position, transform.forward, 2 - i / 8);
            yield return null;
        }
        for (int i = 0; i < 30; i++)
        {
            //transform.RotateAround(planet.transform.position, mainCamera.transform.up, -4 + (Mathf.Abs(i - 14.5f) -0.5f) / 4);
            transform.RotateAround(planet.transform.position, transform.forward, -2 + (Mathf.Abs(i - 14.5f) - 0.5f) / 8);
            yield return null;
        }
        for (int i = 0; i < 15; i++)
        {
            //transform.RotateAround(planet.transform.position, mainCamera.transform.up, 0.5f + i / 4);
            transform.RotateAround(planet.transform.position, transform.forward, 0.25f + i / 8);
            yield return null;
        }
        movin = false;
    }

    IEnumerator Tombo()
    {
        yield return new WaitForSeconds(2.0f);
        transform.RotateAround(planet.transform.position, mainCamera.transform.right, -30);
        movin = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            eG.ENum--;
            Destroy(this.gameObject);
        }

        if(other.gameObject.name == "ResetNet")
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, transform.up);
        }

        if (other.gameObject.name == "ShootZone") { Debug.Log("started"); StartCoroutine("Shoot"); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ShootZone") { Debug.Log("stopped"); StopCoroutine("Shoot"); }
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            Instantiate(bullet, hana.position, hana.rotation, planet.transform); Debug.Log("1");
            yield return new WaitForSeconds(2.0f);
            Instantiate(bullet, hana.position, hana.rotation, planet.transform); Debug.Log("2");
            yield return new WaitForSeconds(1.0f);
            Instantiate(bullet, hana.position, hana.rotation, planet.transform); Debug.Log("3");
            yield return new WaitForSeconds(3.0f);
        }
    }
}
