using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class EndingFlow : MonoBehaviour
{
    public void ChangeScene()
    {
        NCMBObject scoreClass = new NCMBObject("scoreClass");

        //本当はここにスコアの変数を保存
        scoreClass["score"] = "test";

        scoreClass.SaveAsync();

        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(1);
        //FadeManager.Instance.LoadScene("Result", 2.0f);
    }
}