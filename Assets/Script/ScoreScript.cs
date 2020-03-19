using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{   
    public static int score = 0;

    /*
    void Start()
    {
        //シーンが終了してもこのオブジェクトは消えなくなる
        DontDestroyOnLoad(this);
        //シーン始めにOnSceneLoadedが走る処理
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    */

    private void FixedUpdate()
    {
        OnScore(3);
    }



    //Mainシーンの始めに走る
    void OnSceneLoaded(Scene Main, LoadSceneMode mode)
    {
        score = 0;
    }

    //メッセージを受け取る
    void OnScore(int num)
    {
        //scoreに受け取った値を追加する
        score += num;

        //Textコンポーネントを取得する
        Text Score = gameObject.GetComponent<Text>();

        //scoreをテキストとして表示する
        Score.text = "Score:" + score.ToString();
    }
}

