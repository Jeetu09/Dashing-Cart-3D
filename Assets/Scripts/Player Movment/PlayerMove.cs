using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    public float moveSpeed = 10f;
    public float turnSpeed = 10f;

    void FixedUpdate()
    {
        Debug.Log("Player is moving");
        PlayerRigidbody.AddForce(moveSpeed, 0 , 0);


        if (Keyboard.current.aKey.isPressed)
        {
            PlayerRigidbody.AddForce(0, 0, turnSpeed);
        }

        else if(Keyboard.current.dKey.isPressed)
        {
            PlayerRigidbody.AddForce(0, 0, -turnSpeed);
        }
    }
}
