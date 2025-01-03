using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            GameObject.Find("Manager").GetComponent<Manager>().Score += 1;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
