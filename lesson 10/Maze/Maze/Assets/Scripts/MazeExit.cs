using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MazeExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player find the exit of maze");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
