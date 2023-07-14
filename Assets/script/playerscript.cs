using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float speed = 10f;
    public float minX;
    public float maxX; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaY= Input.GetAxis("Vertical")*Time.deltaTime*speed;
        float deltaX =  Input.GetAxis("Horizontal")*Time.deltaTime*speed;

        float newYpos = transform.position.y + deltaY;
        float newXpos = Mathf.Clamp(transform.position.x + deltaX,minX,maxX);
        
        transform.position = new Vector2(newXpos, newYpos);
    }
}
