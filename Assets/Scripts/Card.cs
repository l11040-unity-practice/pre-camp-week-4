using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public SpriteRenderer Front;
    int _idx = 0;

    public void Setting(int num)
    {
        _idx = num;
        Front.sprite = Resources.Load<Sprite>($"rtan{_idx}");
    }
}
