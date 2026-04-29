using System.Collections.Generic;
using UnityEngine;


public class InteractuableObject : MonoBehaviour, IClickeable
{

    public List<Dialogue> textToShow;   

    public void OnClick()
    {
        DialogueManager.instance.ShowDialogue(textToShow);
    }
}
