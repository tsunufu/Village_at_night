using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] Animator anim;

    [SerializeField] private float moveSpeed = 3f;

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        float vertical = Input.GetAxis("Vertical");

        float horizontal = Input.GetAxis("Horizontal");
        // 三次元の移動方向量を計算する
        Vector3 moveValue = new Vector3(-vertical, 0, horizontal) * Time.fixedDeltaTime * moveSpeed;
        // Playerを移動させる
        transform.Translate(moveValue);
        if (vertical != 0 || horizontal != 0)
        {
            anim.SetBool("SetWalk", true);
        }
    }
}
