using UnityEngine;
using System.Collections;

public class ViewControl : MonoBehaviour {
    public float speed = 25;
    public float mouseSpeed = 600;
	// Update is called once per frame
	void Update () {
        //设置ASWD键控制摄像机的移动方向
        //如果Space.World不设置的话，则摄像机会沿着Z轴移动.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float m = Input.GetAxis("Mouse ScrollWheel");
        //Debug.Log(m);
        //transform.Translate(new Vector3(h, 0, v)*Time.deltaTime*speed,Space.World);
        transform.Translate(new Vector3(h*speed, m * mouseSpeed, v*speed) * Time.deltaTime, Space.World);
	}
}
