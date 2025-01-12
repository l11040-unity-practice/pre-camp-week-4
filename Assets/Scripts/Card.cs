using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public SpriteRenderer FrontImg;
    public GameObject Front;
    public GameObject Back;
    public Animator Anime;

    AudioSource _audioSource;
    public AudioClip Clip;
    public int Idx = 0;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Setting(int num)
    {
        Idx = num;
        FrontImg.sprite = Resources.Load<Sprite>($"rtan{Idx}");
    }

    public void OpenCard()
    {
        if (GameManager.Instance.SecondCard != null) return;

        _audioSource.PlayOneShot(Clip);

        Anime.SetBool("isOpen", true);
        Front.SetActive(true);
        Back.SetActive(false);

        if (GameManager.Instance.FirstCard == null)
        {
            GameManager.Instance.FirstCard = this;
        }
        else if (GameManager.Instance.SecondCard == null)
        {
            GameManager.Instance.SecondCard = this;
            GameManager.Instance.Matched();
        }
    }
    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
    }

    void DestroyCardInvoke()
    {
        Destroy(this.gameObject);
    }

    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 1.0f);
    }

    void CloseCardInvoke()
    {

        Front.SetActive(false);
        Back.SetActive(true);
        Anime.SetBool("isOpen", false);
    }
}
