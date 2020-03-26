using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSummonScript : MonoBehaviour
{
    float terminationGaugeUp;
    [SerializeField] GameObject BOSS1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        terminationGaugeUp = EnemyMove.terminationGauge;
        if (terminationGaugeUp >= 10)
        {
            Debug.Log("ゲージがたまった");
            BOSS1.SetActive(true);
        }
    }

    /*
    void terminationGaugeUp(float value)
    {

        
        terminationGauge += value;
        if (terminationGauge <= 10)
        {
            BOSS1.SetActive(true);
        }
        
    }
    */
}
