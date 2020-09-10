using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamZoom : MonoBehaviour
{
    public int currentScrollLevel = 5;
    public int maxScrollLevel;
    public Slider zoomSlider;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        currentScrollLevel -= (int)Input.mouseScrollDelta.y;
        currentScrollLevel = Mathf.Clamp(currentScrollLevel, 0, maxScrollLevel);
        cam.orthographicSize = 10 + currentScrollLevel;
        if(zoomSlider != null)
        {
            zoomSlider.value = currentScrollLevel;
            zoomSlider.gameObject.GetComponentInChildren<Text>().text = (2.0f - currentScrollLevel / 10.0f).ToString() + "X";
        }
    }
}
