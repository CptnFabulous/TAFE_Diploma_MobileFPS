using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Button))]
public class VirtualTrackpad : MonoBehaviour
{

    [HideInInspector] public Vector2 inputValue;
    Button b;

    Camera playerCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        b.GetComponent<Button>();
        //b.onClick.AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            Ray isOnTrackpad = playerCamera.ScreenPointToRay(t.position);

            inputValue = t.deltaPosition;
        }
        else
        {
            inputValue = Vector2.zero;
        }
        print(inputValue);
    }
}
