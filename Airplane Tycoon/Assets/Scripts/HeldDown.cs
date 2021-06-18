using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]

public class HeldDown : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler

{

    private Button _button;
    

    private bool buttonPressed = false;

    private void Awake()
    {
        _button = GetComponent<Button>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonPressed)

            _button.onClick?.Invoke();


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!_button.interactable) return;

        buttonPressed = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonPressed = false;
    }
}
