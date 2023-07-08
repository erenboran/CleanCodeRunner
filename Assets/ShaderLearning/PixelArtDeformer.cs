using UnityEngine;

public class PixelArtDeformer : MonoBehaviour
{
    public Transform characterTransform;
    public float scaleX = 1f;
    public float scaleY = 1f;

    private Vector3 initialScale;

    private void Start()
    {
        initialScale = characterTransform.localScale;
    }

    private void Update()
    {
        float deformationX = Mathf.Sin(Time.time) * scaleX;
        float deformationY = Mathf.Cos(Time.time) * scaleY;

        Vector3 newScale = new Vector3(initialScale.x + deformationX, initialScale.y + deformationY, initialScale.z);
        characterTransform.localScale = newScale;
    }
}
