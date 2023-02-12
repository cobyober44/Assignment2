using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSize : MonoBehaviour
{
    public Slider sizeSlider;

    public float size;
    void Update()
    {
        size = sizeSlider.value;
        Vector3 scale = new Vector3(size,size,size);
        this.transform.localScale = scale;
    }
}
