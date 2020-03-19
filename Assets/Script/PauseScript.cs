using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;
    //[SerializeField] GameObject TitleButton;
   

    public void OnPauseButtonClicked()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
    }

    public void OnContinueButtonClicked()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

    public void OnTitleButtonClicked()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }


}
