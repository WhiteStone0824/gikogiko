using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPan : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5.5f)
        {
            gikopa.gikogiko += 1;
            Destroy(this.gameObject);
        }
    }
}
