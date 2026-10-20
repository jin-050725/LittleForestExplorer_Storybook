using UnityEngine;
using UnityEngine.UI;

public class PageSwitch : MonoBehaviour
{
    public GameObject pageToClose;   // 点按钮之后，要关掉的页面
    public GameObject pageToOpen;    // 点按钮之后，要打开的页面

    public void ChangePage()
    {
        if(pageToClose != null)
        {
            pageToClose.SetActive(false);
        }
        if(pageToOpen != null)
        {
            pageToOpen.SetActive(true);
        }
    }
}

