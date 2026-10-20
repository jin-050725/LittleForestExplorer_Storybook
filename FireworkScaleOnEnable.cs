using UnityEngine;

public class FireworkScaleOnEnable : MonoBehaviour
{
    [Header("烟花缩放参数")]
    public float baseScale = 1f;       // 基础大小
    public float maxScale = 1.35f;     // 最大放大倍数
    public float animSpeed = 3f;       // 缩放速度

    private RectTransform rect;
    private float time;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    void OnEnable()
    {
        time = 0;
        transform.localScale = Vector3.one * baseScale;
    }

    void Update()
    {
        time += Time.deltaTime * animSpeed;
        // 用正弦曲线做平滑的放大缩小循环，像烟花绽放
        float scale = baseScale + (maxScale - baseScale) * (Mathf.Sin(time) * 0.5f + 0.5f);
        rect.localScale = Vector3.one * scale;
    }
}
