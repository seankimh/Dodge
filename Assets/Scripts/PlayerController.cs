using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float fastSpeed = 8f;
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        float speed = Input.GetKey(KeyCode.LeftShift) ? fastSpeed : normalSpeed;

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
