using UnityEngine;
using System.Collections;

public class UsingInstantiate : MonoBehaviour
{
    public GameObject cube;
    public Transform cube2;

    // Use this for initialization
    void Start()
    {
        Invoke("SpawnObject", 3, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButtonDown("Fire"))
        //{
        //    Rigidbody sphere;
        //    sphere = Instantiate(cube, cube2.position, cube2.rotation) as Rigidbody;
        //}

    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(cube, new Vector3(x, 1, z), Quaternion.identity);
    }
}
