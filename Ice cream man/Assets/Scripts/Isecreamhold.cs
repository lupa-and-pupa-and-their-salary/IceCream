using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isecreamhold : MonoBehaviour
{
    public bool hold;
    public float distance;
    RaycastHit2D hit;
    public Transform holdPoint;
    public float throwObj;

    
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!hold)
            {
                Physics2D.queriesStartInColliders = false;
                if (Input.GetAxis("Horizontal") > 0)
                {
                    hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);
                }
                
                if (Input.GetAxis("Horizontal") < 0)
                {
                    hit = Physics2D.Raycast(transform.position, Vector2.left * transform.localScale.x, distance);
                }
                

                if (hit.collider != null && hit.collider.tag == "Truff")
                {
                    hold = true;
                }
            }
            //else
            //{
            //    hold = false;
            //    if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            //    {
            //        hit.collider.gameObject.transform.position = putPoint.position;
            //    }
            //}

            else
            {
                hold = false;
                if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwObj;
                }
            }

        }
        if (hold)
        {
            hit.collider.gameObject.transform.position = holdPoint.position;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.left * transform.localScale.x * distance);

    }
}    