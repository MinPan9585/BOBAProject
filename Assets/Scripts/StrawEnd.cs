using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawEnd : MonoBehaviour
{
    public float radius;
    LayerMask layer;
    GameObject closestObject;

    void Start()
    {
        layer = LayerMask.GetMask("ObjectsInWater");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, layer);
            float minDis = 100f;
            
            for (int i = 0; i < colliders.Length; i++)
            {
                float distance = Vector3.Distance(transform.position, colliders[i].gameObject.transform.position);
                if (distance < minDis)
                {
                    minDis = distance;
                    closestObject = colliders[i].gameObject;
                }
            }

            Animator anim = closestObject.transform.GetChild(0).GetComponent<Animator>();
            anim.SetTrigger("Destroy");
            Destroy(closestObject,0.75f);
        }
        


    }
}
