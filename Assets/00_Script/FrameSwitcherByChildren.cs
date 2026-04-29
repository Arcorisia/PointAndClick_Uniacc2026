using UnityEngine;

/// <summary>
/// Cambia el sprite mostrado entre frame 0 y frame 1 según si un objeto tiene hijos.
/// Requiere un SpriteRenderer con al menos 2 sprites asignados.
/// </summary>
public class FrameSwitcherByChildren : MonoBehaviour
{
    [Header("Objeto a revisar en la jerarquía")]
    [SerializeField] private GameObject targetObject;

    [Header("Frames del clip (ordenados)")]
    [SerializeField] private SpriteRenderer spriteRenderer;

    [Tooltip("Frame 0 = primer frame, Frame 1 = segundo frame")]
    [SerializeField] private Sprite[] frames;

    private void Update()
    {
        if (targetObject == null || spriteRenderer == null || frames.Length < 2)
            return;

        // Si tiene hijos activos o no activos
        if (targetObject.transform.childCount > 0)
        {
            spriteRenderer.sprite = frames[1]; // segundo frame
        }
        else
        {
            spriteRenderer.sprite = frames[0]; // primer frame
        }
        
    }
}