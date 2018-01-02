using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour
{
    public Color color;
    private Texture2D tex = null;

    void Start()
    {
        tex = new Texture2D(1, 1, TextureFormat.RGB24, false);
    }

    void OnPostRender()
    {
        Vector2 pos = Input.mousePosition;
        tex.ReadPixels(new Rect(pos.x, pos.y, 1, 1), 0, 0);
        color = tex.GetPixel(0, 0);
    }
}
