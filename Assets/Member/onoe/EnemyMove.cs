using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    GameObject planet;
    public GameObject mainCamera;
    bool movin;

    public enum Movement
    {
        YuraYura,
        Tombo,
        GuruGuru,
        GuruGuru2
    }
    [SerializeField] Movement movement = Movement.YuraYura;

    // Start is called before the first frame update
    void Start()
    {
        planet = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        switch (movement)
        {
            case Movement.YuraYura:
                if (movin) { StartCoroutine(YuraYura()); }
                else { movin = !movin; }
                break;
            case Movement.GuruGuru:
                transform.RotateAround(planet.transform.position, planet.transform.forward, 1);
                break;
            case Movement.GuruGuru2:
                transform.RotateAround(planet.transform.position, mainCamera.transform.up, 1);
                break;
            case Movement.Tombo:
                break;
        }
    }

    IEnumerator YuraYura()
    {
        for (int i = 0; i < 15; i++)
        {
            transform.RotateAround(planet.transform.position, mainCamera.transform.up, Mathf.PI / 60);
            yield return null;
        }
        for (int i = 0; i < 30; i++)
        {
            transform.RotateAround(planet.transform.position, mainCamera.transform.up, -Mathf.PI / 60);
            yield return null;
        }
        for (int i = 0; i < 15; i++)
        {
            transform.RotateAround(planet.transform.position, mainCamera.transform.up, Mathf.PI / 60);
            yield return null;
        }
        movin = !movin;
    }
}
