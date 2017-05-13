using UnityEngine;
using System.Collections;

[System.Serializable]
public class Wave{
    //保存每一波的敌人生成的属性
    public GameObject enemyPrefab;
    public int count;//每次生成敌人的数量
    public float rate;//每次生成的时间间隔
}
