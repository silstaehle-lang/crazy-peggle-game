using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public bool Colliding;
    public float playerSpeed = 5f;
    Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D doorhitbox)
    {
        if (doorhitbox.gameObject.CompareTag("door hitbox"))
        {

            Colliding = true;
            Debug.Log("colliding");
        }


    }
    void OntriggerEnter2D(Collider2D background)
    {
        if (background.gameObject.CompareTag("background"))
        {
            Colliding = false;
            Debug.Log("not colliding");

        }
    }







    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && Colliding == true)

        {
            Debug.Log("E pressed");

        }
        {
            movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            transform.Translate(movement * playerSpeed * Time.deltaTime);
        }





    }
}
