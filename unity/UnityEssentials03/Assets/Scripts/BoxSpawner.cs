using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [Header("프리팹 지정")]
    public GameObject prdPrefab;

    [Header("생성 간격")]
    public float interval = 3.0f;

    float timer;
    private bool isRunning = true;

    // Update is called once per frame
    void Update()
    {
        if (!isRunning) return;

        timer += Time.deltaTime;    // HW 성능별 FPS 고정

        if(timer >= interval)
        {
            timer = 0;

            Instantiate(prdPrefab,
                        transform.position,
                        Quaternion.identity);
        }
    }

    public void Stop()
    {
        isRunning = false;
    }

    public void StartSpawner()
    {
        isRunning = true;
    }
}
