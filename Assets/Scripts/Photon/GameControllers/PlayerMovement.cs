using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PhotonView PV;
    private CharacterController characterController;

    protected Joystick joystick;

    public float speed = 6.0f;

    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<FixedJoystick>();
        PV = GetComponent<PhotonView>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PV.IsMine)
        {
            BasicMovement();
        }
    }

    void BasicMovement()
    {
        moveDirection = new Vector3(joystick.Horizontal, 0.0f, joystick.Vertical);
        moveDirection *= speed;

        // Debug.Log(moveDirection);

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
