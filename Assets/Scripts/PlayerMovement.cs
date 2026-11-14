using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    Vector2 movement;
    
    // Reference to the SPUM character script
    SPUM_Prefabs spumScript; 

   void Start()
{
    rb = GetComponent<Rigidbody2D>();
    
    // Find the SPUM component on the character
    spumScript = GetComponent<SPUM_Prefabs>(); 

    // IMPORTANT: Initializes the animation dictionary (IDLE, MOVE, etc.)
        // to prevent "KeyNotFound" errors
    if (spumScript != null)
    {
        spumScript.OverrideControllerInit();
        Debug.Log("Sistema de animaciones SPUM inicializado correctamente.");
    }
}

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Logic to trigger movement animations
        if (movement.sqrMagnitude > 0) 
        {
            // If moving, play MOVE animation (default index 0)
            spumScript.PlayAnimation(PlayerState.MOVE, 0);
            
            // Character sprite flipping
            if (movement.x > 0) transform.localScale = new Vector3(1, 1, 1);
            else if (movement.x < 0) transform.localScale = new Vector3(-1, 1, 1);
        }
        else 
        {
            // If idle, play IDLE animation
            spumScript.PlayAnimation(PlayerState.IDLE, 0);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * speed;
    }
}