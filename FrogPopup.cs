using UnityEngine;
using UnityEngine.UI;

public class FrogPopup : MonoBehaviour
{
    // 装青蛙提示文字的整个面板（带底板+TMP文字）
    public GameObject frogTipPanel;

    public void ToggleFrogText()
    {
        if (frogTipPanel != null)
        {
            // 切换显示/隐藏：现在是开就关掉，现在关就打开
            frogTipPanel.SetActive(!frogTipPanel.activeSelf);
        }
    }
}
