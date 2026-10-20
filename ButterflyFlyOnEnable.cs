using UnityEngine;

public class ButterflyFlyOnEnable : MonoBehaviour
{
    [Header("蝴蝶飞舞参数")]
    public float floatRange = 20f;    // 飘动范围
    public float flySpeed = 2f;       // 飘动速度

    private RectTransform rect;
    private Vector2 startPos;
    private float time;

    void Awake()
    {
        rect = GetComponent<RectTransform>();
        startPos = rect.anchoredPosition;
    }

    void OnEnable()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime * flySpeed;
        // 用正弦函数做平滑的上下左右飘动
        float offsetY = Mathf.Sin(time) * floatRange;
        float offsetX = Mathf.Cos(time * 0.7f) * floatRange * 0.5f;
        rect.anchoredPosition = new Vector2(startPos.x + offsetX, startPos.y + offsetY);
    }
}
