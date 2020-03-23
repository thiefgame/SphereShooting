using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOSS1Gimmick : MonoBehaviour
{
    [SerializeField] GameObject Tentacls;
    GameObject Obj;
    float BOSSLife = 1.0f;
    //[SerializeField] GameObject Slider;
    //Slider BOSSSlider;
    [SerializeField] Slider BOSSSlider;

    void Start()
    {
        StartCoroutine("TentaclsInstantiate");
        //BOSSSlider = Slider.GetComponent<Slider>();
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 1, 0));
        BOSSSlider.value = BOSSLife;
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

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            BOSSLife -= 1;
        } 
    }
}
