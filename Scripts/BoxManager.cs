using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    private string _combinationKey = "BlueGreenRed";
    private string _enteredKey = "";
    private int _numberOfGems = 3;
    private int _currentGem = 0;
    public Animator boxAnimator;

    private void GemSelect(GemScript currentSelectedGem)
    {
        // Add the color of the gem to Entered Key
        _enteredKey += currentSelectedGem.gemColor;

        //Each time we select a gem, it will add one to the _currentGem int.
        _currentGem += 1;

        //if _currentGem is equal to _numberOfGems, it will run KeyCheck
    }

    private void KeyCheck()
    {
        if (_enteredKey == _combinationKey)
        {
            print("Order is correct, now opening box");
            //Activate a method that starts the animation
        }

        else 
        {
            print("Order is incorrect, resetting the scene");
            //Activate a method that resets the combination
        }
    }


    private void OpenBox()
    {

    }
    private void ResetBox()
    {

    }
    
}
