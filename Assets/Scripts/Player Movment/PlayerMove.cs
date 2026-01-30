using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    public float moveSpeed = 10f;
    public float turnSpeed = 10f;
    public PlayerMove playermove;

    void FixedUpdate()
    {
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
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided with obstacle!");
            playermove.enabled = false;
        }
    }


}

