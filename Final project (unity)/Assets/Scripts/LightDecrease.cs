using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightDecrease : MonoBehaviour
{
    private Light2D light;
    public float startLightRadius;
    private float currentLightRadius;
    public float decreaseSpeed;
   
    void Start()
    {
        light = GetComponent<Light2D>();
        currentLightRadius = startLightRadius;
    }
    
    void Update()
    {
        currentLightRadius=Mathf.Lerp(currentLightRadius, 0, decreaseSpeed);
        SetLightRadius(currentLightRadius);
    }

    void SetLightRadius(float radius)
    {
        light.pointLightOuterRadius = radius;
    }
}
