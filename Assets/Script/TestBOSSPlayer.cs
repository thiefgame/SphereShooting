using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestBOSSPlayer : MonoBehaviour
{
    [SerializeField] GameObject gp;
    [SerializeField] GameObject bullet;
    float PlayerLife = 1.0f;
    [SerializeField] Slider PlayerSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-0.1f, 0.0f, 0.0f);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0.1f, 0.0f, 0.0f);
        }
        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f, 0.0f, 0.1f);
        }
        // 後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f, 0.0f, -0.1f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(bullet, gp.transform.position, Quaternion.Euler(transform.forward));
        }

        PlayerSlider.value = PlayerLife;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BOSSBullet")
        {
            PlayerLife -= 0.1f;
        }
    }
}
