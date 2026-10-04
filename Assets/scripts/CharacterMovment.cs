using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;        // how fast the character walks
    public float rotationSpeed = 10f;   // how fast it turns toward movement
    public bool stickToTerrain = true;  // keep feet on hills/valleys

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 1. Read directional input (W/A/S/D or Arrow keys)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 2. Convert input into a movement direction
        Vector3 movement = new Vector3(horizontal, 0f, vertical);
        movement = Vector3.ClampMagnitude(movement, 1f); // no faster diagonals

        // 3. Move and rotate the character
        if (movement.magnitude > 0.1f)
        {
            transform.position += movement * moveSpeed * Time.deltaTime;

            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  targetRotation,
                                                  rotationSpeed * Time.deltaTime);
        }

        // 4. Keep the character standing on the terrain surface
        if (stickToTerrain && Terrain.activeTerrain != null)
        {
            Vector3 pos = transform.position;
            pos.y = Terrain.activeTerrain.SampleHeight(pos)
                  + Terrain.activeTerrain.transform.position.y;
            transform.position = pos;
        }

        // 5. Update the Animator (Idle <-> Running)
        animator.SetFloat("Speed", movement.magnitude);
    }
}