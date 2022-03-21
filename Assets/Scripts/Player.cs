using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float moveForward = 5f;
    public float moveSideWays = 5f;

    void FixedUpdate()
    {
        //moveforward
        transform.Translate(0, 0, moveForward * Time.fixedDeltaTime);
        
        //move sideways
        //float movX = SimpleInput.GetAxis("Horizontal");
        //transform.Translate(movX * moveSideWays * Time.fixedDeltaTime, 0, 0);

    }

    public enum SIDE {XtremeLeft, Left, Mid, Right}

    public SIDE m_Side = SIDE.Mid;
    float NewXPos = 0f;
    public bool SwipeLeft;
    public bool SwipeRight;
    public float XValue = 2f;
    private float x = 0f;
    public float speedDodge;
    //private CharacterController control;
    
    void Start()
    {
        //control = GetComponent<CharacterController>();
        //transform.position = Vector3.zero;
    }

    void Update()
    {
        //SwipeLeft = Input.GetKeyDown(KeyCode.A);
        //SwipeRight = Input.GetKeyDown(KeyCode.D);
        SwipeLeft = SwipeManager.swipeLeft;
        SwipeRight = SwipeManager.swipeRight;

        if(SwipeLeft)
        {
            if(m_Side == SIDE.Mid)
            {
                NewXPos = -XValue;
                m_Side = SIDE.Left;
            }
            else if(m_Side == SIDE.Right)
            {
                NewXPos = 0;
                m_Side = SIDE.Mid;
            }
            else if(m_Side == SIDE.Left)
            {
                NewXPos = -XValue - XValue;
                m_Side = SIDE.XtremeLeft;
            }

        }
        else if(SwipeRight)
        {
            if(m_Side == SIDE.Mid)
            {
                NewXPos = XValue;
                m_Side = SIDE.Right;
            }
            else if(m_Side == SIDE.Left)
            {
                NewXPos = 0;
                m_Side = SIDE.Mid;
            }
            else if(m_Side == SIDE.XtremeLeft)
            {
                NewXPos = -XValue;
                m_Side = SIDE.Left;
            }
        }
        //moveforward
        transform.Translate(0, 0, moveForward * Time.fixedDeltaTime);
        
        //move sideways
        //float movX = SimpleInput.GetAxis("Horizontal");
       
        x = Mathf.Lerp(x, NewXPos, Time.deltaTime * speedDodge);
        transform.Translate((x - transform.position.x) * Vector3.right);
        //control.Move((x - transform.position.x) * Vector3.right);
    }
}
