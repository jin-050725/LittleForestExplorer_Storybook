using UnityEngine;
using UnityEngine.UI;

public class FireworkPopup : MonoBehaviour
{
    // 烟花弹窗【整个Panel面板】（底板+里面的TMP文字）
    public GameObject fireworkTipPanel;

    public void ToggleFireworkText()
    {
        if (fireworkTipPanel != null)
        {
            // 切换显示/隐藏
            fireworkTipPanel.SetActive(!fireworkTipPanel.activeSelf);
        }
    }
}

