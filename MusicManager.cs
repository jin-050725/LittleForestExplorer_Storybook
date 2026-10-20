using UnityEngine;

public class MusicManager : MonoBehaviour
{
    // 全局只保留一个音乐播放器
    public static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            // 切换场景时，这个物体不会被销毁，音乐就不会断
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 如果新场景又生成了一个，就删掉重复的
            Destroy(gameObject);
        }
    }
}
