using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject planet;
    public GameObject player;
    GameObject gp;

    // Start is called before the first frame update
    void Start()
    {
        gp = player.transform.Find("GeneratePoint").gameObject;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(bullet, gp.transform.position, Quaternion.Euler(player.transform.forward));
        }
    }
}
