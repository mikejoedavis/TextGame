using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{

    [TextArea(15, 20)] [SerializeField] string StoryText;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return StoryText;
    }

  public State[] getNextStates()
    {
        return nextStates;
    }




}
