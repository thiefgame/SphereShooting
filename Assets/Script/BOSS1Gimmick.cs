using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOSS1Gimmick : MonoBehaviour
{
    [SerializeField] GameObject Tentacls;
    GameObject Obj;
    float BOSSLife = 1.0f;
    [SerializeField] Slider BOSSSlider;
    [SerializeField] GameObject Split1BOSS;

    void Start()
    {
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
            BOSSLife -= 0.1f;
            BOSSSlider.value = BOSSLife;

            if (BOSSLife <= 0)
            {
                Split1BOSS.SetActive(true);
                Destroy(this.gameObject);
            }
        } 
    }
}
