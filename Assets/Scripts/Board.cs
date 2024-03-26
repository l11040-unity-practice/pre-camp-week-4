using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject Card;
    void Start()
    {
        for (int i = 0; i < 16; i++)
        {
            GameObject tempCard = Instantiate(Card, this.transform);

            float x = (i % 4) * 1.4f - 2.1f;
            float y = (i / 4) * 1.4f - 2.5f;

            tempCard.transform.position = new Vector2(x, y);
        }
    }
}
