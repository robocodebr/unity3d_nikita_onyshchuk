using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int rotate = 0;

private void OnCollsionEnter(Collision collision)
{
    if (collision.gameObject.tag == "Player")
    {
        rotate = 20;
        collision.gameObject.GetComponent<Player>().score += 10;
    }
}
}