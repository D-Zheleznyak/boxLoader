using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerButton : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private string text;

    [SerializeField] private GameObject obj;
    [SerializeField] private Material mat_true;
    [SerializeField] private Material mat_false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(text, true);
            obj.GetComponent<Renderer>().material = mat_false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(text, false);
            obj.GetComponent<Renderer>().material = mat_true;
        }
    }
}
