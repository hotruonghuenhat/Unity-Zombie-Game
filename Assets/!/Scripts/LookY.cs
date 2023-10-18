using UnityEngine;
using System.Collections;

public class LookY : MonoBehaviour {

    // Biến cho biết sự thay đổi của trỏ chuột  
    public float _mouseY = 0.0f;
    // Độ nhạy 
    public float _sensitivity = 5.0f;
    // Update is called once per frame
    void Update()
    {
        _mouseY = -Input.GetAxis("Mouse Y"); // Tìm giá trị 
        // Khai báo giá trị quay theo góc Euler 
        Vector3 rot = transform.localEulerAngles;
        //gán giá trị góc quay y theo chuột 
        rot.x += _mouseY * _sensitivity; // nhân với độ nhạy 
        transform.localEulerAngles = rot; // gán lại góc quay đó 
    }
}
