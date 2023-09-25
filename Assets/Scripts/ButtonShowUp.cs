using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShowUp : MonoBehaviour
{
    float timer = 4;
    public GameObject btn;
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            btn.SetActive(true);
        }
    }
}
