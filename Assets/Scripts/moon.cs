using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour
{
    public float deg = 0.9f;
    public GameObject center;
    public float speed = 100;
    float progress = 0;
    float distance = 0;
    public float x = 7;
    public float z = 5;

    // Start is called before the first frame update
    void Start()
    {
        distance = Vector3.Distance(center.transform.position, this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, deg, 0), Space.Self);
        OvalRotate();
    }
    //绕椭圆形旋转
    void OvalRotate()
    {
        progress += Time.deltaTime * speed;
        Vector3 p = new Vector3(x * Mathf.Cos(progress * Mathf.Deg2Rad), 0, z * Mathf.Sin(progress * Mathf.Deg2Rad));
        this.transform.position = center.transform.position + p;
    }
}
