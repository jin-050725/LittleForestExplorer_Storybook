using UnityEngine;
using System.Collections;

public class BounceOnShow : MonoBehaviour
{
    [Header("弹跳参数")]
    public float bounceScale = 1.2f;  // 弹跳最大倍数
    public float bounceSpeed = 8f;    // 弹跳速度
    public int bounceCount = 2;       // 弹跳次数

    private Vector3 originalScale;

    void Awake()
    {
        originalScale = transform.localScale;
    }

    // 页面一显示就自动触发
    void OnEnable()
    {
        StopAllCoroutines();
        transform.localScale = originalScale;
        StartCoroutine(Bounce());
    }

    IEnumerator Bounce()
    {
        for (int i = 0; i < bounceCount; i++)
        {
            // 放大
            while (transform.localScale.x < originalScale.x * bounceScale)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, originalScale * bounceScale, bounceSpeed * Time.deltaTime);
                yield return null;
            }
            // 缩回
            while (transform.localScale.x > originalScale.x * 1.01f)
            {
                transform.localScale = Vector3.Lerp(transform.localScale, originalScale, bounceSpeed * Time.deltaTime);
                yield return null;
            }
            transform.localScale = originalScale;
        }
    }
}
