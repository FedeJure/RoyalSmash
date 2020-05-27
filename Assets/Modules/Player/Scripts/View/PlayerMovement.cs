using Mirror;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(NetworkIdentity))]
public class PlayerMovement : NetworkBehaviour
{
    Input input;
    Vector2 movement;
    Rigidbody2D body;
    private NetworkIdentity networkIdentity;

    private void Awake()
    {
        input = new Input();
        body = GetComponent<Rigidbody2D>();
        input.Movement.MovePlayer.performed += ctx => movement = ctx.ReadValue<Vector2>();
        networkIdentity = GetComponent<NetworkIdentity>();
    }
    

    private void FixedUpdate()
    {
        if (!base.hasAuthority) return;
        
        float velocity = 10;
        body.velocity = movement * velocity;
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
