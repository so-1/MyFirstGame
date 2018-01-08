using System.Collections;
using UnityEngine;

public class ColorChecker : MonoBehaviour
{

    Texture2D _tex;
    public Color32[] _color;

    private void Start()
    {
        // 画像を入れる箱を用意
        _tex = new Texture2D(1, 1, TextureFormat.RGBA32, false);
    }

    private void Update()
    {
        // マウス位置
        Vector2 position = Input.mousePosition;
        // 画面外を判別
        if (position.x < 0 || position.x >= Screen.width) return;
        if (position.y < 0 || position.y >= Screen.height) return;
        // コルーチンメソッド呼び出し
        StartCoroutine(GetColor(position));
    }

    // コルーチンのメソッド
    IEnumerator GetColor(Vector2 position)
    {
        // 描画終了まで待機
        yield return new WaitForEndOfFrame();
        // 画像を取り込む
        _tex.ReadPixels(new Rect(position, Vector2.one), 0, 0, false);
        // 色を変数に記憶させる
        _color = _tex.GetPixels32();
        if ( _color[0].r <= 10 && _color[0].g <= 10 && _color[0].b <= 10)
        {
            Destroy(GameObject.Find("PLAYER"));
          

        }
    }

   
       
}