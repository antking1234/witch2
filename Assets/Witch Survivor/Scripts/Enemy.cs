using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    private Rigidbody2D target; // 플레이어를 넣는 변수 target
    private Rigidbody2D rigid;  // 에너미 리짓바디2D

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>(); // 현재 게임오브젝트의 Rigidbody2D를 가져온다.        
    }

    private void OnEnable()
    {
        target = GameManager.Instance.player.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 targetDirection = target.position - rigid.position;
        rigid.MovePosition(rigid.position + targetDirection * speed * Time.fixedDeltaTime);
    }
}
