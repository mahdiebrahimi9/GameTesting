using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shooting();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(10 * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(10 * Time.deltaTime, 0f, 0f);
        }
    }


    public void Shooting()
    {
        GameObject B = Instantiate(Bullet, GameObject.Find("Position").transform.position, Quaternion.identity);
        B.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);
        Destroy(B, 2f);
    }
}
