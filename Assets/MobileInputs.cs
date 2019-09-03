using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileInputs : MonoBehaviour
{
    public VirtualJoystick movement;
    public VirtualTrackpad camera;
    public Button jump;
    public bool jumpInput;
    public Button crouch;
    public Button fire;
    public Button reload;
    public Button scope;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //jump.onClick.AddListener()
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ButtonInputDown(bool inputBool)
    {

    }
    void ButtonInputUp(string buttonName)
    {


    }

    /*
    void InputJump()
    {
        
    }
    void InputCrouch()
    {

    }
    void InputFire()
    {

    }
    void InputReload()
    {

    }
    void InputScope()
    {

    }
    */
}
