using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public static Vector2 movement;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // ќтримуЇмо вх≥д в≥д користувача
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ќбчислюЇмо вектор руху
        movement = new Vector2(moveHorizontal, moveVertical);
        movement = movement.normalized;
    }

    void FixedUpdate()
    {
        // –ухаЇмо гравц€
        playerTransform.Translate(movement * moveSpeed * Time.fixedDeltaTime);
    }
}
