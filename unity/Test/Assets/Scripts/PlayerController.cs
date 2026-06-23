using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Tooltip("전진후진 속도 (units/sec).")]
    public float speed = 5.0f;

    [Tooltip("회전속도 (degrees/sec).")]
    public float rotationSpeed = 70.0f;

    [Tooltip("점프강도")]
    public float jumpForce = 3.0f;

    [Header("UI 설정")]
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI winText; // 승리 문구를 띄울 텍스트 변수 추가!

    private Rigidbody rb;
    private int coinCount = 0;
    private bool isWon = false; // 승리했는지 체크하는 변수

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null) Debug.LogWarning("PlayerController needs a Rigidbody.");

        UpdateCoinUI();

        // 게임 시작할 때는 승리 문구를 숨깁니다.
        if (winText != null) winText.gameObject.SetActive(false);
    }

    private void Update()
    {
        // 승리했다면 조작을 막습니다.
        if (isWon) return;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }

    private void FixedUpdate()
    {
        // 승리했다면 움직임을 막습니다.
        if (isWon) return;

        Vector2 moveInput = Vector2.zero;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveInput.y = 1f;
        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveInput.y = -1f;
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveInput.x = -1f;
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveInput.x = 1f;

        Vector3 movement = transform.forward * moveInput.y * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        float turnDirection = moveInput.x;
        if (moveInput.y < 0) turnDirection = -turnDirection;

        float turn = turnDirection * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        if (coinText != null) coinText.text = "Coin: " + coinCount + "/21";
    }

    // 탈출구에 닿았을 때 호출될 함수
    public void GameClear()
    {
        if (isWon) return; // 이미 승리했다면 중복 실행 방지

        isWon = true;
        rb.linearVelocity = Vector3.zero; // 플레이어 정지

        if (winText != null)
        {
            winText.gameObject.SetActive(true); 
            winText.text = "WIN!!";
        }

        Debug.Log("게임 클리어!");
    }

    public int GetCoinCount()
    {
        return coinCount;
    }
}