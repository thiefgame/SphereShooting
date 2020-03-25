using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOSS1Gimmick : MonoBehaviour
{
    [SerializeField] GameObject Tentacls;
    GameObject Obj;
    [SerializeField] float BOSSLife = 40.0f;
    [SerializeField] GameObject Split1BOSS;
    [SerializeField] GameObject OverBossLife;

    void Start()
    {
        //BossLifeScript = OverBossLife.GetComponent();
        StartCoroutine("TentaclsInstantiate");
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 1, 0));       
    }

    IEnumerator TentaclsInstantiate()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Obj = Instantiate(Tentacls, this.transform.position, Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            BOSSLife -= 1.0f;

            OverBossLife.SendMessage("GetOverBossLife",0.01f);

            if (BOSSLife <= 0)
            {
                Split1BOSS.SetActive(true);
                Destroy(this.gameObject);
            }
        } 
    }
}
