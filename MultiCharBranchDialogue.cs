using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultiCharBranchDialogue : MonoBehaviour
{
    [Header("问题与选项")]
    public string questionText;
    public string choiceAText;
    public string choiceBText;

    [Header("狐狸回复")]
    public string foxReplyA;
    public string foxReplyB;

    [Header("第二个角色（单角色场景不用勾）")]
    public bool useSecondChar = false;
    public string char2ReplyA;
    public string char2ReplyB;

    [Header("界面物体引用")]
    public GameObject questionBubble;
    public TMP_Text questionLabel;
    public GameObject choiceButtons;
    public TMP_Text choiceALabel;
    public TMP_Text choiceBLabel;
    public GameObject foxReplyBubble;
    public TMP_Text foxReplyLabel;
    public GameObject char2ReplyBubble;
    public TMP_Text char2ReplyLabel;

    [Header("弹出延迟设置")]
    public float startDelay = 0.8f;
    public float choiceDelay = 0.3f;

    void OnEnable()
    {
        ResetAll();
        Invoke(nameof(ShowQuestion), startDelay);
    }

    void ResetAll()
    {
        questionBubble.SetActive(false);
        choiceButtons.SetActive(false);
        foxReplyBubble.SetActive(false);
        if (useSecondChar)
        {
            char2ReplyBubble.SetActive(false);
        }
    }

    void ShowQuestion()
    {
        questionLabel.text = questionText;
        choiceALabel.text = choiceAText;
        choiceBLabel.text = choiceBText;

        questionBubble.SetActive(true);
        Invoke(nameof(ShowChoices), choiceDelay);
    }

    void ShowChoices()
    {
        choiceButtons.SetActive(true);
    }

    public void OnChoiceA()
    {
        choiceButtons.SetActive(false);
        
        foxReplyLabel.text = foxReplyA;
        foxReplyBubble.SetActive(true);

        if (useSecondChar)
        {
            char2ReplyLabel.text = char2ReplyA;
            char2ReplyBubble.SetActive(true);
        }
    }

    public void OnChoiceB()
    {
        choiceButtons.SetActive(false);
        
        foxReplyLabel.text = foxReplyB;
        foxReplyBubble.SetActive(true);

        if (useSecondChar)
        {
            char2ReplyLabel.text = char2ReplyB;
            char2ReplyBubble.SetActive(true);
        }
    }
}