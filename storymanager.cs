using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    // 所有页面面板，后面在Unity里拖入
    public GameObject panelHome;
    public GameObject panelScene1;
    public GameObject panelScene2;
    public GameObject panelScene3;
    public GameObject panelScene4;

    // 音乐播放器
    public AudioSource bgmAudio;

    void Start()
    {
        // 游戏打开，显示主页
        ShowPanel(panelHome);

        // 自动播放背景音乐，循环
        if (bgmAudio != null)
        {
            bgmAudio.Play();
            bgmAudio.loop = true;
        }
    }

    // 切换页面的函数，所有按钮都调用这个
    public void ShowPanel(GameObject targetPanel)
    {
        panelHome.SetActive(false);
        panelScene1.SetActive(false);
        panelScene2.SetActive(false);
        panelScene3.SetActive(false);
        panelScene4.SetActive(false);

        if (targetPanel != null)
        {
            targetPanel.SetActive(true);
        }
    }
}

