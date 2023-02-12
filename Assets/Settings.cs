using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider sizeSlider;
    public static float playerSize;
    private float size;
    public GameObject player;
    public Dropdown colorDropdown;
    void Start()
    {
        
    }
    public void ChangeSize()
    {
        sizeSlider.value = size;    

        player.transform.localScale = new Vector3(size, size, size);
        player.transform.localPosition = new Vector3(player.transform.localPosition.x, 0.5f * size, player.transform.localPosition.z);
    }

}
