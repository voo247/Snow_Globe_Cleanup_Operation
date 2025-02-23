using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDecoBall : MonoBehaviour
{
    bool flag = false;

    void Start()
    {
        gameObject.SetActive(flag);
    }

    void OnMouseDown()
    {
        GameObject.Find("Deco").transform.Find("Ball").gameObject.SetActive(flag);
        flag = !flag;
        gameObject.SetActive(flag);
    }
}