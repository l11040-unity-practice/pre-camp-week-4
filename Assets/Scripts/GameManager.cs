using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public Card FirstCard;
    public Card SecondCard;
    public Text TimeTxt;
    float _time = 0.0f;

    void Update()
    {
        _time += Time.deltaTime;
        TimeTxt.text = _time.ToString("N2");
    }

    public void Matched()
    {
        if (FirstCard.Idx == SecondCard.Idx)
        {
            FirstCard.DestroyCard();
            SecondCard.DestroyCard();
        }
        else
        {
            FirstCard.CloseCard();
            SecondCard.CloseCard();
        }
        FirstCard = null;
        SecondCard = null;
    }
}
