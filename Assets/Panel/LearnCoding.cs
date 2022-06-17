
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class LearnCoding : UdonSharpBehaviour
{ //will have a access modifier of default unless specficed
    public bool isCoding = true;

    private int simpleNumber = -1;

    private char simpleChar = '%';

    private float fractionNumber = 1.5f;

    private string simpleString = "Hello World";

    GameObject simpleGameObject = null;    
    void Start()
    {
        
    }

    public override void Interact(){
        if(isCoding == true){
            Debug.Log("I am coding");
        }
        else{
            Debug.Log("I am not coding");
        }
        //isCoding = MyMethod();
        
    }

    private bool MyMethod(){
        isCoding = false;
        simpleString = "I have been clicked";
        Debug.Log(simpleString + " " + simpleNumber + " " + simpleChar + " " + fractionNumber);
        bool myLocalBool = true; // I am a local variable, I will be destroyed after the method is called
        return myLocalBool;
    }

    
}
