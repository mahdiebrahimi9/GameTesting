using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // keyboard key
        if (Input.GetKey(KeyCode.D))
        {
            GameObject.Find("Player").transform.position += new Vector3(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GameObject.Find("Player").transform.position -= new Vector3(0.01f, 0f, 0f);
        }
      
    }
    //private void OnMouseDown()
    //{
    //    GameObject.Find("Player").transform.position = new Vector3(0f, 0f, 0f);
    //}

    private void OnMouseDrag()
    {
        // mouse click
        if (this.name == "ButtonRight")
        {
            GameObject.Find("Player").transform.position += new Vector3(0.01f, 0f, 0f);
        }

        if (this.name == "ButtonLeft")
        {
            GameObject.Find("Player").transform.position -= new Vector3(0.01f, 0f, 0f);
        }
    }

    //private void OnMouseUp()
    //{
    //    print("c");
    //}

}
