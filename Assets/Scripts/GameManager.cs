using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text TimeTxt;
    float _time = 0.0f;
    void Start()
    {

    }

    void Update()
    {
        _time += Time.deltaTime;
        TimeTxt.text = _time.ToString("N2");
    }
}
