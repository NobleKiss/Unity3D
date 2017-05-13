using UnityEngine;
using System.Collections;

public class EnemySpaWner : MonoBehaviour {
    //敌人的个数
    public static int CountEnemyAlive = 0;
    //敌人的波数
    public Wave[] waves;
    //开始位置
    public Transform START;
    //每隔多长时间生成一波
    public float waverate= 0.2f;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    //生成敌人
    IEnumerator SpawnEnemy()
    {
        foreach (Wave wave in waves)
        {
            for (int i = 0; i < wave.count; i++)
            {
                GameObject.Instantiate(wave.enemyPrefab, START.position, Quaternion.identity);
                CountEnemyAlive++;
                if(i!=wave.count-1)//暂停线程后生成下一个敌人.
                    yield return new WaitForSeconds(wave.rate);
            }
            //当还有敌人的时候，暂停0帧
            while (CountEnemyAlive>0)
            {
                yield return 0;
            }
            //暂停线程后生成下一波敌人.
            yield return new WaitForSeconds(waverate);
        }
    }
}
