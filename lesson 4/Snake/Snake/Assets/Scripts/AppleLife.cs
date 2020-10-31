using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-10, 10);
        float y = Random.Range(-4, 4);

        // createApple();  
        
        transform.position = new Vector3(x, y, 0);
    }
   
    //public GameObject ApplePref;
    //GameObject AppleObj;

    void createApple()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
       SnakeLife s = collision.gameObject.GetComponent<SnakeLife>();

        if (s != null)
        {
            s.addChank();
            s.SnakeScore++;
            Destroy(gameObject);
        }
            }
}
