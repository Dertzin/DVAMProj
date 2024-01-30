using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    Color objectColor;

    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = objectColor;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChooseColor(Color Color)
    {
        objectColor = Color;
    }
}
