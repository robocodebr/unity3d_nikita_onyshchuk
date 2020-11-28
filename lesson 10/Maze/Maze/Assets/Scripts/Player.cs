using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public int score = 0;
    void Start()
    {
        rg = GetComponent<Rigidbody>();   
    }
    private Rigidbody rg;
    float speed = 500;

    // Update is called once per frame
    void FixedUpdate()
    {
    if(Input.GetAxis("Horizontal")<0)
    {
            rg.AddForce(new Vector3(-1, 0, 0) * speed*Time.fixedDeltaTime);
           /// GetComponent<Rigidbody>().velocity -= new Vector3(0.6f, 0, 0);
    }else if (Input.GetAxis("Horizontal") > 0) {
                rg.AddForce(new Vector3(1, 0, 0) * speed* Time.fixedDeltaTime);
                /// GetComponent<Rigidbody>().velocity += new Vector3(0.6f, 0, 0);
            

}

    
    if(Input.GetAxis("Vertical")< 0)
    {
    rg.AddForce(new Vector3(0, 0, -1) * speed * Time.fixedDeltaTime);
    ///GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, 0.6f);

    }
     else if(Input.GetAxis("Vertical")>0)
    {
    rg.AddForce(new Vector3(0, 0, 1) * speed * Time.fixedDeltaTime);
   /// GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 0.6f);
    }
    }
}
