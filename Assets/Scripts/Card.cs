using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public SpriteRenderer FrontImg;
    public GameObject Front;
    public GameObject Back;
    public Animator Anime;
    int _idx = 0;

    public void Setting(int num)
    {
        _idx = num;
        FrontImg.sprite = Resources.Load<Sprite>($"rtan{_idx}");
    }

    public void OpenCard()
    {
        Anime.SetBool("isOpen", true);
        Front.SetActive(true);
        Back.SetActive(false);
    }
}
