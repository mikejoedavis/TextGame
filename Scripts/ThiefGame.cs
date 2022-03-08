using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThiefGame : MonoBehaviour
{
    [SerializeField] Text TextComponent = default;
    [SerializeField] State StartingState;

    State currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = StartingState;
        TextComponent.text = currentState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        manageState();

        
    }

    private void manageState()
    {
        var storyoptions = currentState.getNextStates();
        
        for(int index = 0; index < storyoptions.Length; index ++)

        if (Input.GetKeyDown(KeyCode.Alpha1+index))
        {
            currentState = storyoptions[index];

        }

        else if (Input.GetKeyDown(KeyCode.Q))
        {
                currentState = StartingState;
        }

        TextComponent.text = currentState.GetStateStory();
    }
}
