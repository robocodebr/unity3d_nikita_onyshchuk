using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-8, 8);
        float y = Random.Range(-5, 5);

        // createApple();  
        AppleObj = Instantiate(ApplePref) as GameObject;
        transform.position = new Vector3(x, y, 0);
    }
   
    public GameObject ApplePref;
    GameObject AppleObj;

    void createApple()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
