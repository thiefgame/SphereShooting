using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
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
            yield return new WaitForSeconds(3.0f);
            Vector3 pos = transform.position + (transform.position - player.transform.position);
            Instantiate(enemy, pos, Quaternion.Euler(-30, 0, 0), transform);
        }
    }
}
