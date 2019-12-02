using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
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
        if (Input.GetKey(KeyCode.T))
        {
            if (SceneController.AlreadyLoadScene("Main"))
            {
                SceneManager.UnloadSceneAsync("Main");
            }
            SceneManager.LoadScene("Title", LoadSceneMode.Additive);
        }
    }
}
