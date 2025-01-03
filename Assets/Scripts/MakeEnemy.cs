using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public float timer;
    void Start()
    {

    }

    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer > 3)
        {
            timer = 0;
            SpwanEnemy();
        }
    }
    void SpwanEnemy()
    {
        Instantiate(Enemy, new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity);
    }
}
