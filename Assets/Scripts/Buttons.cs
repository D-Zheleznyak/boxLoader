using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [Header("--- Кнопки анимаций ---")]
    public Animator boxAnim;
    [SerializeField] private string text;

    public boxTaked bT;

    [SerializeField] private GameObject btns;

    public int boxPoint = 0;

    public void BoxOpen()
    {
        boxAnim.SetBool(text, true);
        boxPoint = 1;
    }
    public void BoxClosed()
    {
        boxAnim.SetBool(text, false);
        boxPoint = 0;
    }

    public void BoxDropped()
    {
        bT.OnDropBox();
        bT = null;
    }

    public void OnLoader()
    {

    }

    public void InterfaceBoxActivate()
    {
        btns.SetActive(true);
    }

    public void InterfaceBoxDeactivate()
    {
        btns.SetActive(false);
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            InterfaceBoxActivate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            BoxOpen();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BoxClosed();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            BoxDropped();
            InterfaceBoxDeactivate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            OnLoader();
        }
    }
    */
}
