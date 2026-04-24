using UnityEngine;

public class MovimientoYZ : MonoBehaviour
{
    public float speed = 5f;
    public SpriteRenderer spriteRenderer;

    private Vector3 movimiento;

    void Update()
    {
        float moveZ = 0f;
        float moveY = 0f;

        // Movimiento en Z (horizontal según tu lógica)
        if (Input.GetKey(KeyCode.D))
        {
            moveZ = -1f; // D -> Z negativo
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveZ = 1f; // A -> Z positivo
        }

        // Movimiento en Y (vertical)
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f; // W -> Y positivo
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f; // S -> Y negativo
        }

        // Vector de movimiento (sin tocar X)
        movimiento = new Vector3(0f, moveY, moveZ).normalized;

        // Aplicar movimiento
        transform.Translate(movimiento * speed * Time.deltaTime, Space.World);

        // Flip del sprite según dirección en Z
        if (moveZ > 0) // Z positivo
        {
            spriteRenderer.flipX = true;
        }
        else if (moveZ < 0) // Z negativo
        {
            spriteRenderer.flipX = false;
        }
    }
}