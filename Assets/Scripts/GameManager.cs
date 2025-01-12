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
    public GameObject EndTxt;
    public AudioClip Clip;
    AudioSource _audioSource;
    float _time = 0.0f;
    public int CardCount = 0;
    void Start()
    {
        Time.timeScale = 1.0f;
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        _time += Time.deltaTime;
        TimeTxt.text = _time.ToString("N2");

        if (_time > 30f)
        {
            GameOver();
        }
    }

    public void Matched()
    {
        if (FirstCard.Idx == SecondCard.Idx)
        {
            _audioSource.PlayOneShot(Clip);
            FirstCard.DestroyCard();
            SecondCard.DestroyCard();
            CardCount -= 2;
            if (CardCount == 0)
            {
                GameOver();
            }
        }
        else
        {
            FirstCard.CloseCard();
            SecondCard.CloseCard();
        }
        FirstCard = null;
        SecondCard = null;
    }

    void GameOver()
    {
        EndTxt.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
