using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;

    void Update()
    {
        Debug.Log("Player is moving");
        PlayerRigidbody.AddForce(10f , 0 , 0); 
    }
}
