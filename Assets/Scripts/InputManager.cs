using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class InputManager : MonoBehaviour
{
    public VectorIntroduction objectNeedMove;
    public KeyCode key = KeyCode.A;
    public int mouseButton;
    public float timeRest = 1f;//tạo ra màn hình nhập liệu trong Inspector để truyền giá trị mặc định
    private float timeControl = 0f;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        InputKeyboard();
        InputMouse();
        InputAxis();
    }
    protected void InputKeyboard()
    {
        //Xử lý phát hiện ra Input của người dùng
        //class Input là class chịu tách nhiệm đọc input của người dùng
        bool startPressKey = Input.GetKeyDown(KeyCode.A);
        bool holdPressKey = Input.GetKey(KeyCode.A);
        bool releasePressKey = Input.GetKeyUp(KeyCode.A);
        if (startPressKey == true)
        {
            timeControl = 0;
            Debug.Log("Bat dau nhan phim A");
        }
        else if (holdPressKey == true)
        {
            if(timeControl > timeRest) 
            { 
                Debug.Log("Dang giu phim A"); 
            }
            
        }
        else if (releasePressKey == true)
        {
            Debug.Log("Da nha phim A");
        }
    }//thông báo nhận input từ bàn phím chạy theo 60 frame nên hiện rất nhiều
    protected void InputMouse()
    {
        bool startClick = Input.GetMouseButtonDown(0);
        bool releaseClick = Input.GetMouseButtonUp(0);
        bool holdClick = Input.GetMouseButton(0);
        if (startClick == true)
        {
            timeControl = 0;//khi ấn mặc định để timecontrol = 0 để bắt đầu sự kiện
            if (timeControl > timeRest) 
            {
                Debug.Log("Bat dau an chuot");
            }
            
        }
        else if (holdClick == true)
        {
            timeControl += Time.deltaTime;//để cộng dần thời gian chờ khi giữ
            Debug.Log("Dang giu chuot");
        }
        else if (releaseClick == true)
        {
            Debug.Log("Da nha chuot");
        }
        InputKeyboard();
    }//thông báo nhận input từ chuột
    protected void InputAxis()
    {
        //Input nhận từ phím điều hướng mũi tên PC
        //Axis truyền vào Axis name được lấy từ Project Setting/InputManager/Axes trong Unity và có các thông số tăng giảm trục 
        //Unity
        //Input.GetAxis("Horizontal");//-1...0...1 trong ngoặc để loại điều khiển trục trong Axes
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        
            objectNeedMove.Move(new Vector3(horizontalAxis,verticalAxis,0));//new bien(giatri) de truyen vao gia tri cho class
       
        

    }
}
