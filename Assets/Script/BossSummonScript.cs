using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSummonScript : MonoBehaviour
{
    float terminationGaugeUp;
    [SerializeField] GameObject BOSS1;
    bool isCalledOnce = false;
    [SerializeField] GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        terminationGaugeUp = EnemyMove.terminationGauge;
        if (terminationGaugeUp >= 3)
        {
            if (!isCalledOnce)
            {
                Debug.Log("ゲージがたまった");
                BOSS1.SetActive(true);
                planet.GetComponent<EnemyGenerator>().enabled = false;
                GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("BOSSBullet");
                foreach (GameObject obj in tagobjs)
                {
                    Destroy(obj);
                }
                isCalledOnce = true;
            }
        }
    }
}
