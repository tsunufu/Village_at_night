using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCharacterMove : MonoBehaviour
{
    [SerializeField] Animator anim;

    [SerializeField] private float moveSpeed = 3f;

    private void FixedUpdate()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        // 横矢印入力を値で返し変数「horizontal」に格納
        float horizontal = Input.GetAxis("Horizontal");
        // 三次元の移動方向量を計算する
        Vector3 moveValue = new Vector3(-horizontal, 0, 0) * Time.fixedDeltaTime * moveSpeed;
        // Playerを移動させる
        transform.Translate(moveValue);
        anim.SetBool("SetWalk", true);

        //if(Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    transform.position = new Vector3(Time.fixedDeltaTime * moveSpeed, 0, 0);
        //    transform.Rotate(0, 90, 0);
        //}
    }
}
