using UnityEngine;

public class SunAnim : MonoBehaviour
{
    [Header("动画参数")]
    public float rotateSpeed = 20f;    // 旋转速度
    public float scaleRange = 0.05f;   // 轻微缩放幅度
    public float scaleSpeed = 1f;      // 缩放速度

    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale;
    }

    void Update()
    {
        // 本地自转（UI专用，不会跑偏）
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime, Space.Self);

        // 轻微呼吸缩放（自身缩放，UI也能用）
        float offset = Mathf.Sin(Time.time * scaleSpeed) * scaleRange;
        transform.localScale = startScale + Vector3.one * offset;
    }
}
