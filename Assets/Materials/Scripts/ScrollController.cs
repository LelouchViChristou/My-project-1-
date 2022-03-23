using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollController : MonoBehaviour
{
    public float scroll_speed = 0.1f;
    private MeshRenderer meshrenderer;
    private float scroll_x;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    void Scroll()
    {
        scroll_x = Time.time * scroll_speed;
        Vector2 offset = new Vector2(scroll_x, 0f);
        meshrenderer.sharedMaterial.SetTextureOffset("milky-way-gb575e8a67_1920", offset);
    }
}
