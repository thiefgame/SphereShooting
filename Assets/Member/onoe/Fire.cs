using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    Bullet b_cs;
    public GameObject planet;
    public GameObject player;
    GameObject gp;
    public bool auto = true;
    [Range(0.1f,5.0f)]
    public float autoFireRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        gp = player.transform.Find("GeneratePoint").gameObject;
        b_cs = bullet.GetComponent<Bullet>();
        if (auto) { StartCoroutine(AutoFire()); }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !auto)
        {
            b_cs.Instantiate(bullet, gp.transform.position, Quaternion.Euler(player.transform.forward), planet, player);
        }
    }

    IEnumerator AutoFire()
    {
        while (true)
        {
            b_cs.Instantiate(bullet, gp.transform.position, Quaternion.Euler(player.transform.forward), planet, player);
            yield return new WaitForSeconds(autoFireRate);
        }
    }
}
