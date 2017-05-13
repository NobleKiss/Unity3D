using UnityEngine;
using System.Collections;

public class WayPoint : MonoBehaviour {

    public static Transform[] position;
    private void Awake()
    {
        //获取所有道路转折点
        position = new Transform[transform.childCount];
        for (int i = 0; i < position.Length; i++)
        {
            position[i] = transform.GetChild(i);
        }
    }
}
