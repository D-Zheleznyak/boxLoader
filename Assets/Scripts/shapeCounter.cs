using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shapeCounter : MonoBehaviour
{
    public int cubeCount;
    public int sphereCount;
    public int cylinderCount;

    [SerializeField] private TextMeshProUGUI cubeCountText;
    [SerializeField] private TextMeshProUGUI sphereCountText;
    [SerializeField] private TextMeshProUGUI cylinderCountText;

    private void FixedUpdate()
    {
        cubeCountText.text = " ”¡€: " + cubeCount.ToString();
        sphereCountText.text = "—‘≈–€: " + sphereCount.ToString();
        cylinderCountText.text = "÷»À»Õƒ–€: " + cylinderCount.ToString();
    }
}
