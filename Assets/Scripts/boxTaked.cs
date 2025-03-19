using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTaked : MonoBehaviour
{
    private Buttons btns;

    [SerializeField] private GameObject prfb;
    private GameObject dropItemSpawnPoint;

    [SerializeField] private GameObject[] objsInBox;
    public int count;

    private Animator anim;

    void Start()
    {
        btns = GameObject.Find("Canvas").GetComponent<Buttons>();
        btns.boxAnim = GetComponent<Animator>();

        btns.bT = GetComponent<boxTaked>();

        anim = GetComponent<Animator>();
    }

    void Search()
    {
        dropItemSpawnPoint = GameObject.Find("dropItemSpawnPoint");
    }
    public void OnDropBox()
    {
        Search();
        Instantiate(prfb, dropItemSpawnPoint.transform.position, dropItemSpawnPoint.transform.rotation);

        Destroy(gameObject);
    }

    public void OnLoad()
    {
        Destroy(objsInBox[count]);
        count++;

        if (count == 4)
        {
            btns.InterfaceBoxDeactivate();

            anim.SetBool("isOpen", false);
            anim.SetTrigger("destroy");
        }
    }

    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
