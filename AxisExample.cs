using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AxisExample : MonoBehaviour
{
    public float range;
    //public TextMesh textOutput;
    Text display;

    void Start()
    {
        display = GameObject.Find("Canvas/T").GetComponent<Text>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float yPos = v * range;

        display.text = "hi";
        //GetComponent<TextMesh>().text = "Hello World";

        //textOutput = (TextMesh)textOutput.GetComponent("T");
        //transform.position = new Vector3(xPos, yPos, 0);
        //display.text = "Horizontal Value Returned: " + h.ToString("F2") + "\nVertical Value Returned: " + v.ToString("F2");
    }
}
