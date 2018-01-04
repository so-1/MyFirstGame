using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateColor : MonoBehaviour
{
    private GetColor getColors;

    void Start()
    {
        getColors = FindObjectOfType<GetColor>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.color = getColors.colors;
    }
}
