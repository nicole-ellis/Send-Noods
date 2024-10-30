using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITalkable // enables object to be talked to
{
    public void Talk(DialogueText dialogueText);
}
