using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;

    private Rigidbody2D target; // �÷��̾ �ִ� ���� target
    private Rigidbody2D rigid;  // ���ʹ� �����ٵ�2D

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>(); // ���� ���ӿ�����Ʈ�� Rigidbody2D�� �����´�.        
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
