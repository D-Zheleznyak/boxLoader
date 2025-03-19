using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowGarb : MonoBehaviour, IInteractable
{
    [SerializeField] private string text;

    [SerializeField] private playerController p;
    [SerializeField] private Buttons btns;
    [SerializeField] private boxTaked bT;

    [SerializeField] private string boxColor;
    [SerializeField] private string color;

    private shapeCounter counter;

    void Start()
    {
        counter = GameObject.Find("Canvas").GetComponent<shapeCounter>();
    }

    public string GetDescription()
    {
        return text;
    }

    void Search()
    {
        boxColor = p.myBoxColor;
        bT = btns.bT;
    }
    public void OnGarb()
    {
        if (boxColor == color)
            counter.cylinderCount++;
    }

    public void Interact()
    {
        Search();

        if (boxColor == color && btns.boxPoint == 1)
        {
            OnGarb();
            bT.OnLoad();
        }   
    }
}
