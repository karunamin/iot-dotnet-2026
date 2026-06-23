using UnityEngine;

public class EscapePoint : MonoBehaviour
{
    public int requiredCoins = 21;
    private Collider portalCollider;

    void Start()
    {
        // 오브젝트의 콜라이더를 가져옵니다.
        portalCollider = GetComponent<Collider>();

        // 시작할 때는 통과할 수 없는 단단한 '벽' 상태로 만듭니다.
        if (portalCollider != null)
        {
            portalCollider.isTrigger = false;
        }
    }

    // 물리적으로 부딪혔을 때 발동하는 함수로 변경 (OnTriggerEnter -> OnCollisionEnter)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();

            if (player != null)
            {
                int currentCoins = player.GetCoinCount();

                // 동전 조건을 충족했다면!
                if (currentCoins >= requiredCoins)
                {
                    // 콜라이더를 Trigger로 바꿔서 플레이어가 스윽 통과할 수 있게 문을 열어줍니다.
                    portalCollider.isTrigger = true;

                    // 플레이어에게 승리 신호를 보냅니다.
                    collision.gameObject.SendMessage("GameClear", SendMessageOptions.DontRequireReceiver);
                }
                else
                {
                    // 동전이 모자라면 통과되지 않고 벽에 쿵 부딪히며 로그가 뜹니다.
                    Debug.Log("Not Enough Coin");
                }
            }
        }
    }
}