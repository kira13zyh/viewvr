using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Clicked on the cube!");
        players = GameObject.FindGameObjectsWithTag("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {


        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + players[i].name);
        }

        //rb.useGravity = true;
    }
}
