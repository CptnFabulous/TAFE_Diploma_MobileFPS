using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//[RequireComponent(typeof (Button))]
[RequireComponent(typeof(RectTransform))]
public class VirtualTrackpad : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    RectTransform rt;

    [HideInInspector] public Vector2 inputValue;
    //Button b;

    //Camera playerCamera;



    Touch trackpadTouch;
    bool trackpadTouched;

    Vector2 input;


    void Awake()
    {
        rt = GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //b.GetComponent<Button>();
        //b.onClick.AddListener();
    }

    // Update is called once per frame
    void Update()
    {

        /*
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
        */
        
        foreach(Touch t in Input.touches)
        {
            if (RectTransformUtility.RectangleContainsScreenPoint(rt, t.position)) // Detects if touch is inside trackpad rectTransform area
            {

                if (trackpadTouched == false)
                {
                    trackpadTouch = t;
                    trackpadTouched = true;
                    print("Finger is touching trackpad");
                }
                
            }
        }
        trackpadTouched = false;

        input += trackpadTouch.deltaPosition;
        print(trackpadTouch.deltaPosition);
        


    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        print("Trackpad touched");
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        print(eventData.dragging);
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        //input = Vector2.zero;
        print("Trackpad released");
    }
}
