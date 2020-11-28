using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Canvas : MonoBehaviour
{
    public Text time;
    public Text score;
    Player playerScript;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + ((int)Time.realtimeSinceStartup).ToString();
        score.text = "Score: " + playerScript.score;
     }
}
