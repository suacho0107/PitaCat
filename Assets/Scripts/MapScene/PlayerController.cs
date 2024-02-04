using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D myRB;
    private Animator    myAnim;
    // bool isHorizonMove;     // �밢�� �̵� ���� ���

    [SerializeField]
    private float speed;

    public VectorValue startingPosition;

    void Awake()
    {
        myRB    = GetComponent<Rigidbody2D>();
        myAnim  = GetComponent<Animator>();
        transform.position = startingPosition.initialValue;
    }

    void Update()
    {
        myRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * speed * Time.deltaTime;

        // Animator �Ķ���� ���� �Ǽ�����
        myAnim.SetFloat("MoveX", myRB.velocity.x);
        myAnim.SetFloat("MoveY", myRB.velocity.y);

        // ���� �� Player�� �ٶ󺸴� ������ Player�� ������ �̵��������� ����
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
