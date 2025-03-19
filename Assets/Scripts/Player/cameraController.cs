using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    private float mouseX;
    private float mouseY;

    public float sensitivityMouse;

    public Transform player;

    public Joystick joy;

    public GameObject p;
    private playerController anotherSc;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        anotherSc = p.GetComponent<playerController>();
    }

    void LateUpdate()
    {
        mouseX = joy.Horizontal * sensitivityMouse * Time.deltaTime;
        mouseY = joy.Vertical * sensitivityMouse * Time.deltaTime;

        player.Rotate(mouseX * new Vector3(0, 1, 0));

        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}
