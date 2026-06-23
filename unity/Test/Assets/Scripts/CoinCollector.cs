using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [Header("회전 설정")]
    [Range(0, 360)]
    public float rotationSpeed = 150f;

    void Update()
    {
        // 동전을 부드럽게 회전시킵니다.
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 부딪힌 물체가 플레이어 라면
        if (other.CompareTag("Player"))
        {
            // 플레이어 오브젝트에 있는 "AddCoin" 함수를 찾아서 실행하라고 신호를 보냅니다.
            other.SendMessage("AddCoin", SendMessageOptions.DontRequireReceiver);

            // 동전 삭제
            Destroy(gameObject);
        }
    }
}