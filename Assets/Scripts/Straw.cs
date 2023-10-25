using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straw : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0);

        float mouseDegree = Mathf.Atan2(mouseWorldPos.y - 1.72f, mouseWorldPos.x);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, mouseDegree * Mathf.Rad2Deg - 90));
    }
}
