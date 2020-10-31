using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DethWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       SnakeLife s = collision.gameObject.GetComponent<SnakeLife>();
        if(s != null)
        {
            // Destroy(collision.gameObject);
            s.DestroySnake();
         
        }
    }

}
