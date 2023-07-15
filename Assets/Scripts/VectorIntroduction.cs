using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorIntroduction : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        Vector2 vectorA = new Vector2(0, 1);//truyền 1 vector A(o;1)
        Vector3 vectorB = new Vector3(0, 1, 0);
        Debug.Log(vectorA);
        Debug.Log(vectorB);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;//di component gan voi GO nay theo vector3 time.deltatime la thoi gian can de hien thi khung hinh
        //vector3 thanh (speed,0,0)
    }
    public void Move(Vector3 steps) 
    {
        //step = vector3 * Time.deltaTime
        this.transform.position += steps * speed * Time.deltaTime;
    }
}
