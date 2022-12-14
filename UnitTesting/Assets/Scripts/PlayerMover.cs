using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour, IPlayerMover
{
    private CharacterController characterController;
    public int Health { get; set; }
    [SerializeField]
    private bool isPlayer;
    public bool IsPlayer => isPlayer;
    public float playerSpeed;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        characterController.Move(new Vector3(horizontal, 0, vertical) * playerSpeed);
    }
}
