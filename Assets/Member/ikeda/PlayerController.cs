using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject obj;
        //回転用
        Vector2 startPos; //タッチした座標
        Quaternion startRot; //タッチしたときの回転
        float width, height, diag; //スクリーンサイズ
        float tx, ty; //変数

        // Start is called before the first frame update
        void Start()
        {
            width = Screen.width;
            height = Screen.height;
            diag = Mathf.Sqrt(Mathf.Pow(width, 2) + Mathf.Pow(height, 2));
        }

        // Update is called once per frame
        void Update()
        {
            var phase = GodTouch.GetPhase();
            if (phase == GodPhase.Began)
            {
                //タッチ開始処理
                startPos = GodTouch.GetPosition();
                startRot = obj.transform.rotation;
            }
            else if (phase == GodPhase.Moved)
            {
                tx = (GodTouch.GetPosition().x - startPos.x) / width; //横移動量(-1<tx<1)
                ty = (GodTouch.GetPosition().y - startPos.y) / height; //縦移動量(-1<ty<1)
                obj.transform.rotation = startRot;
                obj.transform.Rotate(new Vector3(90 * ty, -90 * tx, 0), Space.World);
            }
            else if (phase == GodPhase.Ended)
            {
                //タッチ終了
                Debug.Log("TouchEnded");
            }
        }
    }
}
