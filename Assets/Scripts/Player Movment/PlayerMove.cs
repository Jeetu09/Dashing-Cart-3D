using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Microsoft.Unity.VisualStudio.Editor;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    public float moveSpeed = 10f;
    public float turnSpeed = 20f;
    public PlayerMove playermove;
    public GameObject UI;

    void Start()
    {
       UI.SetActive(false);
    }

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
            UI.SetActive(true);

        }

        else if(collision.gameObject.name == "Last Wall")
            {
                Debug.Log("You Won");
                playermove.enabled = false;
                UI.SetActive(true);

        }
    }

    public void RestartGame()
    {
        playermove.enabled = true;
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}

