using UnityEngine;

public class HandheldCamera : MonoBehaviour
{
    [Header("Movimiento base")]
    public float positionAmount = 0.05f;
    public float rotationAmount = 1.5f;

    [Header("Velocidad")]
    public float positionSpeed = 1.2f;
    public float rotationSpeed = 1.5f;

    [Header("Ruido fino")]
    public float noiseAmount = 0.02f;
    public float noiseSpeed = 5f;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private float seed;

    void Start()
    {
        initialPosition = transform.localPosition;
        initialRotation = transform.localRotation;
        seed = Random.Range(0f, 100f);
    }

    void Update()
    {
        float time = Time.time;

        // Movimiento suave tipo balanceo
        float posX = Mathf.Sin(time * positionSpeed) * positionAmount;
        float posY = Mathf.Cos(time * positionSpeed * 0.8f) * positionAmount;

        // Ruido más irregular (Perlin)
        float noiseX = (Mathf.PerlinNoise(seed, time * noiseSpeed) - 0.5f) * noiseAmount;
        float noiseY = (Mathf.PerlinNoise(seed + 1, time * noiseSpeed) - 0.5f) * noiseAmount;

        Vector3 finalPosition = initialPosition + new Vector3(posX + noiseX, posY + noiseY, 0f);
        transform.localPosition = finalPosition;

        // Rotación leve
        float rotX = Mathf.Sin(time * rotationSpeed) * rotationAmount;
        float rotY = Mathf.Cos(time * rotationSpeed * 0.7f) * rotationAmount;

        float noiseRotX = (Mathf.PerlinNoise(seed + 2, time * noiseSpeed) - 0.5f) * rotationAmount;
        float noiseRotY = (Mathf.PerlinNoise(seed + 3, time * noiseSpeed) - 0.5f) * rotationAmount;

        Quaternion finalRotation = Quaternion.Euler(
            initialRotation.eulerAngles.x + rotX + noiseRotX,
            initialRotation.eulerAngles.y + rotY + noiseRotY,
            initialRotation.eulerAngles.z
        );

        transform.localRotation = finalRotation;
    }
}