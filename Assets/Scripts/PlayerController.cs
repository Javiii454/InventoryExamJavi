using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float movementSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       _rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, _rb.linearVelocity.y); 
    }
}
