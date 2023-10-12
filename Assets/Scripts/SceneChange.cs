using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string SecondScene;

    private void Start()
    {

    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(SecondScene);
    }
}
