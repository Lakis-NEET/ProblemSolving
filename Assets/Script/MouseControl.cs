using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    public float speed = 0.1f;
    private Rigidbody2D rigidBody2D;
    private Vector3 mouseClick;
    private Camera cm;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //mengambil camera yang saat ini digunakan
        cm = Camera.main;
    }

    void Update()
    {
        //jika tombol mouse kiri diklik
        if (Input.GetMouseButtonDown(0))
        {
            //Mengambil posisi mouse ketika diklik
            mouseClick = cm.ScreenToWorldPoint(Input.mousePosition);        
        }
    }
    private void FixedUpdate()
    {
        //Dot akan bergerak menuju posisi mouse diklik dengan kecepatan yang sudah ditentukan
        rigidBody2D.transform.position = Vector2.MoveTowards(transform.position, mouseClick, speed);
    }

}
