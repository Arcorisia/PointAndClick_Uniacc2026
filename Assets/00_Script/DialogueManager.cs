using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public CanvasGroup canvasGroup;
    public TextMeshProUGUI textDialogue;

    public List<string> actualDialogue;
    int indexDialogue = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        HideDialogue();
    }

    public void ShowDialogue(List<string> dialogue)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        indexDialogue = 0;
        actualDialogue.Clear();
        actualDialogue.AddRange(dialogue);
        ClickManager.instance.blocked = true;

        textDialogue.text = actualDialogue[indexDialogue];
    }
    public void NextDialgoue()
    {
        indexDialogue++;
        if(indexDialogue >= actualDialogue.Count)
        {
            HideDialogue();
        }
        else
        {
            textDialogue.text = actualDialogue[indexDialogue];
        }
    }
    public void HideDialogue()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        ClickManager.instance.blocked = false;

        textDialogue.text = "";
    }


}
