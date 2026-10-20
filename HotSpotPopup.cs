using UnityEngine;
using UnityEngine.UI;

public class HotSpotPopup : MonoBehaviour
{
    [Header("要弹出/关闭的弹窗面板")]
    public GameObject popupPanel;

    // 点击热点，切换弹窗显示/隐藏
    public void TogglePopup()
    {
        if (popupPanel != null)
        {
            // 取反：显示就隐藏，隐藏就显示
            popupPanel.SetActive(!popupPanel.activeSelf);
        }
    }
}
