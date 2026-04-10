using System.Collections.Generic;
using UnityEngine;
public interface IClickeable
{
    public void OnClick();
}

public class InteractuableObject : MonoBehaviour, IClickeable
{

    public List<string> textToShow;
    public void OnClick()
    {
        DialogueManager.instance.ShowDialogue(textToShow);
    }
}
