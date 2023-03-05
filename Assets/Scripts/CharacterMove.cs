using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] Animator anim;

    float moveSpeed = 3f;

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        // 横矢印入力を値で返し変数「horizontal」に格納
        float horizontal = Input.GetAxis("Vertical");
        // 縦矢印入力を値で返し変数「vertical」に格納
        float vertical = Input.GetAxis("Horizontal");
        // 三次元の移動方向量を計算する
        Vector3 moveValue = new Vector3(-horizontal, 0, vertical) * Time.fixedDeltaTime * moveSpeed;
        // Playerを移動させる
        transform.Translate(moveValue);
        anim.SetBool("SetWalk", true);
    }
}
