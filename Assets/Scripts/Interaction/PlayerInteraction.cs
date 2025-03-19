using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCam;
    public float interactionDistance = 10f;

    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;

    [SerializeField] private GameObject btnTake;
    [SerializeField] private GameObject btnLoad;

    IInteractable II;

    void Update()
    {
        InteractionRay();
    }

    void InteractionRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                hitSomething = true;
                interactionText.text = interactable.GetDescription();
                II = interactable;

                if (hit.collider.CompareTag("box"))
                {
                    btnTake.SetActive(true);
                }

                else
                {
                    btnTake.SetActive(false);
                }

                if (hit.collider.CompareTag("garb"))
                {
                    btnLoad.SetActive(true);
                }

                else
                {
                    btnLoad.SetActive(false);
                }
            }
        }

        interactionUI.SetActive(hitSomething);
    }

    public void OnInteract()
    {
        II.Interact();
    }
}
