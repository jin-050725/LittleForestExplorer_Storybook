using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // 给按钮OnClick直接调用
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
