using UnityEngine.SceneManagement;
using System.Linq;

public static class SceneController
{
    /** 既にシーンが読み込まれているかどうか */
    public static bool AlreadyLoadScene(string name)
    {
        return SceneManager.GetAllScenes()
            .Count(scene => scene.name == name)
            > 0;
    }
}
