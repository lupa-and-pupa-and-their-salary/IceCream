using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kon : MonoBehaviour
{
    public Transform Inp;
    public Transform putPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Inp.transform.position = putPoint.position;
    }
}
