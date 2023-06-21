using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotPotato : MonoBehaviour
{
    Player player;
    private int shotDirection; // 1 for to the right, -1 for to the left
    private float potatoShotForce = 5.0f;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
        //need to determine if this potato is going to the right or left
        shotDirection = player.playerFaceDirection;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveTater();
    }

    void moveTater()
    {
        // shot moves to the right
        if (shotDirection == 1)
        {
            transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime * potatoShotForce;
        }
        // shot moves to the left
        else if (shotDirection == -1)
        {
            transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime * potatoShotForce;
        }
        else
            Debug.Log("The tater did not get the direction... womp womp!");
    }
}
