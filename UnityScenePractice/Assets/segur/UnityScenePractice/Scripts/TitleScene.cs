﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    void Awake()
    {
        if (!SceneController.AlreadyLoadScene("Common"))
        {
            SceneManager.LoadScene("Common", LoadSceneMode.Additive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            if (SceneController.AlreadyLoadScene("Title"))
            {
                SceneManager.UnloadSceneAsync("Title");
            }
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        }
    }
}
