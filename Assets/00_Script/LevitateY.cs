using UnityEngine;

public class LevitateY : MonoBehaviour
{
    [Header("Configuración de levitación")]
    public float amplitude = 0.5f;   // Altura máxima del movimiento
    public float speed = 1f;         // Velocidad de oscilación

    private float initialY;
    private float timeOffset;

    void Start()
    {
        // Guardamos la posición inicial en Y
        initialY = transform.position.y;

        // Offset para que no todos los objetos se muevan igual
        timeOffset = Random.Range(0f, 100f);
    }

    void Update()
    {
        float newY = initialY + Mathf.Sin((Time.time + timeOffset) * speed) * amplitude;

        Vector3 pos = transform.position;
        pos.y = newY;
        transform.position = pos;
    }
}