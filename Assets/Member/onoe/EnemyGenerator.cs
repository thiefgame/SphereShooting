using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    [HideInInspector] public int eNum;
    public int ENum
    {
        get { return eNum; }
        set { eNum = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        eNum = 1;
        StartCoroutine(PopEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PopEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(eNum % 10 + 1);
            Vector3 pos = transform.position + (transform.position - player.transform.position);
            Instantiate(enemy, pos, Quaternion.Euler(-30, 0, 0), transform);
            eNum++;
        }
    }
}
