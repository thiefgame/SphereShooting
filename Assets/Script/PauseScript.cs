using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    //ポーズボタンを押したとき時間を止める
    public void OnPauseButtonClicked()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }

    //コンティニューボタンを押したとき時間を動かす
    public void OnContinueButtonClicked()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

    //タイトルボタンを押したとき時間を動かしてタイトルに飛ぶ
    public void OnTitleButtonClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }


}
