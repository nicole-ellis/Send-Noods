using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Dialogue/New Dialogue Container")] // makes the dialogue contained within the text box
public class DialogueText : ScriptableObject
{
    public string SpeakerName;

    [TextArea(5, 10)]
    public string[] paragraphs;
}
