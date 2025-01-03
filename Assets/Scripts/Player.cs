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
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Shooting();
        }
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.name);
    }

    public void Shooting()
    {
        GameObject B = Instantiate(Bullet, GameObject.Find("Position").transform.position, Quaternion.identity);
        B.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 100);
        Destroy(B, 2f);
    }
}
