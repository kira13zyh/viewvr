using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{

    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);

        Disable();
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Disable()
    {
        StartCoroutine(RemoveAfterSeconds(3, myObject));
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }


}
