using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    //定义速度
    public float Speed = 10;
    //定义到达位置的集合
    private Transform[] position;
    private int index = 0;//每个转折点的索引
	// Use this for initialization
	void Start () {
        position = WayPoint.position;
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
    void Move()
    {
        //if (index >= position.Length) return;
        transform.Translate((position[index].position - transform.position).normalized * Time.deltaTime*Speed);
        if (Vector3.Distance(position[index].position, transform.position) < 0.2f)//计算两点之间的距离
        {
            index++;//下一个转折点
        }
        //如果到达最后一个转折点，则将当前小球销毁
        if (index > position.Length - 1)
            ReachDestination();
    }
    //到达目的地
    void ReachDestination()
    {
        GameObject.Destroy(this.gameObject);
    }
    //摧毁
    private void OnDestroy()
    {
        EnemySpaWner.CountEnemyAlive--; 
    }
}
