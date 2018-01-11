using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour
{
    public Color colors;
    private Texture2D tex = null;

    void Start()
    {
        
        tex = new Texture2D(1, 1, TextureFormat.RGB24, false);
    }

    void Update()
    {
        Vector2 m_pos = Input.mousePosition;

        tex.ReadPixels(new Rect(m_pos.x, m_pos.y, 1, 1), 0, 0);
        colors = tex.GetPixel(0,0);
        GetComponent<Renderer>().material.color = colors;
        Debug.Log(m_pos.x+","+ ","+m_pos.y);
    }
    /*
    void OnPostRender()
    {
        
     
        Vector2 pos = Input.mousePosition;
        tex.ReadPixels(new Rect(pos.x, pos.y, 1, 1), 0, 0);
        color = tex.GetPixel(0, 0);
       
    }
    */
}
