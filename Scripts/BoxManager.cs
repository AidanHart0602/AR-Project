using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    [SerializeField]
    private string _combinationKey = "blueredgreen";
    private string _enteredKey = "";
    private int _numberOfGems = 3;
    private int _currentGem = 0;
    public Animator boxAnimator;
    public GemScript[] GemArray;
    public void GemSelect(GemScript currentSelectedGem)
    {
        // Add the color of the gem to Entered Key
        _enteredKey += currentSelectedGem.gemColor;

        //Each time we select a gem, it will add one to the _currentGem int.
        _currentGem += 1;

        //Make the gem Emmissive
        currentSelectedGem.ChangeEmission(true);

        //if _currentGem is equal to _numberOfGems, it will run KeyCheck
        if(_currentGem == _numberOfGems)
        {
            KeyCheck();
        }
    }

    private void KeyCheck()
    {
        if (_enteredKey == _combinationKey)
        {
            print("Order is correct, now opening box");
            OpenBox();
        }

        else 
        {
            print("Order is incorrect, resetting the scene");
            ResetBox();
        }
    }


    private void OpenBox()
    {
        boxAnimator.SetTrigger("Open");
        print("Combination is correct");
    }
    private void ResetBox()
    {
        _currentGem = 0;
        _enteredKey = "";
        print("Combination Key is incorrect, resetting");
        foreach(var GemScript in GemArray)
        {
            GemScript.ChangeEmission(false);
        }
    }
    
}
