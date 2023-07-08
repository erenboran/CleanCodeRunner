using UnityEngine;

public class PixelArtAnimator : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int pixelSize = 8;
    public float speed = 1f;

    private Texture2D originalTexture;
    private int width;
    private int height;
    private int newWidth;
    private int newHeight;
    private Texture2D pixelArtTexture;
    private float timer = 0f;

    private void Start()
    {
        originalTexture = spriteRenderer.sprite.texture;
        width = originalTexture.width;
        height = originalTexture.height;
        newWidth = width / pixelSize;
        newHeight = height / pixelSize;
        pixelArtTexture = new Texture2D(newWidth, newHeight);

        UpdatePixelArt();
    }

    private void Update()
    {
        timer += Time.deltaTime * speed;
        UpdatePixelArt();
    }

    private void UpdatePixelArt()
    {
        for (int y = 0; y < newHeight; y++)
        {
            for (int x = 0; x < newWidth; x++)
            {
                int offsetX = (int)(Mathf.PerlinNoise(x * 0.1f, y * 0.1f + timer) * pixelSize);
                int offsetY = (int)(Mathf.PerlinNoise(x * 0.1f + timer, y * 0.1f) * pixelSize);
                Color pixelColor = originalTexture.GetPixel((x * pixelSize) + offsetX, (y * pixelSize) + offsetY);

                for (int i = 0; i < pixelSize; i++)
                {
                    for (int j = 0; j < pixelSize; j++)
                    {
                        pixelArtTexture.SetPixel(x, y, pixelColor);
                    }
                }
            }
        }

        pixelArtTexture.Apply();

        Sprite pixelArtSprite = Sprite.Create(pixelArtTexture, new Rect(0, 0, newWidth, newHeight), Vector2.one * 0.5f);
        spriteRenderer.sprite = pixelArtSprite;
    }
}
