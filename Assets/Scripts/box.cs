using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour, IInteractable
{
    [SerializeField] private string text;

    [SerializeField] private GameObject prfb;
    private GameObject camPoint;

    [SerializeField] private string myColor;
    private playerController p;

    void Start()
    {
        p = GameObject.Find("Player").GetComponent<playerController>();
    }

    public string GetDescription()
    {
        return text;
    }

    void Search()
    {
        camPoint = GameObject.Find("camPoint");
    }
    public void Interact()
    {
        Search();
        Instantiate(prfb, camPoint.transform);
        p.myBoxColor = myColor;

        Destroy(gameObject);
    }
}
