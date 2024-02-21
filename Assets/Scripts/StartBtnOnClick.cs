using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtnOnClick : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
