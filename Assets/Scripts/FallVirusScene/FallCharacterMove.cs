using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCharacterMove : MonoBehaviour
{
    [SerializeField] Animator anim;

    [SerializeField] private float moveSpeed = 3f;

    [SerializeField] private VirusScoreManager virusScoreManager;

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
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("衝突");
            virusScoreManager.score--;
            Destroy(other.gameObject);
            virusScoreManager.UpdateScoreText();
        }
    }
}
