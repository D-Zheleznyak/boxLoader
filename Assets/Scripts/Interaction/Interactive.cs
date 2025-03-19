using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    [SerializeField] private Camera fpsCamera;
    private Ray ray;
    private RaycastHit hit;

    [SerializeField] private float maxDistanceRay;

    private void Update()
    {
        Ray();
        DrawRay();
    }

    private void Ray()
    {
        ray = fpsCamera.ScreenPointToRay(new Vector2 (Screen.width / 2, Screen.height / 2));
    }

    private void DrawRay()
    {
        if (Physics.Raycast(ray, out hit, maxDistanceRay))
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistanceRay, Color.blue);
        }
        if (hit.transform == null)
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistanceRay, Color.red);
        }
    }
}
