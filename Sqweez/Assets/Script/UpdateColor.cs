using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColor : MonoBehaviour
{
    private GetColor getColor;

    void Start()
    {
        getColor = GameObject.FindObjectOfType<GetColor>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = getColor.color;
    }
}
