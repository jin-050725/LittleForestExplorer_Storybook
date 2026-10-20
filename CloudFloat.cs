using UnityEngine;

public class CloudFloat : MonoBehaviour
{
    public float floatRange = 1.2f;
    public float speed = 0.6f;

    private Vector3 startLocalPos;

    void Start()
    {
        // 记录UI本地坐标
        startLocalPos = transform.localPosition;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * floatRange;
        transform.localPosition = new Vector3(startLocalPos.x + offset, startLocalPos.y, startLocalPos.z);
    }
}
