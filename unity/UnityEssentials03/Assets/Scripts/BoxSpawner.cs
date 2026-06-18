using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject prdPrefab;

    public float interval = 3.0f;

    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;    // HW 성능별 FPS 고정

        if(timer >= interval)
        {
            timer = 0;

            Instantiate(prdPrefab,
                        transform.position,
                        Quaternion.identity);
        }
    }
}
