using UnityEngine;

public class ClickBall : MonoBehaviour
{
    bool flag = true;

    void Start()
    {
        gameObject.SetActive(flag);
    }

    void OnMouseDown()
    {
        GameObject.Find("Tree").transform.Find("BallDecoT").gameObject.SetActive(flag);
        flag = !flag;
        gameObject.SetActive(flag);
    }
}
