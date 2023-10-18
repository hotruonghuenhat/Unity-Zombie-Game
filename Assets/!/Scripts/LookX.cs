using UnityEngine;
using System.Collections;

public class LookX : MonoBehaviour {

    // Biến cho biết sự thay đổi của trỏ chuột  
    public float _mouseX = 0.0f;
	// Độ nhạy 
    public float _sensitivity = 5.0f;
	// Update is called once per frame
	void Update () {
        _mouseX = Input.GetAxis("Mouse X"); // Tìm giá trị 
        // Khai báo giá trị quay theo góc Euler 
         Vector3 rot = transform.localEulerAngles;
         //gán giá trị góc quay y theo chuột 
         rot.y += _mouseX*_sensitivity; // nhân với độ nhạy 
         transform.localEulerAngles = rot; // gán lại góc quay đó 
	}

    // Use this for initialization
    void Start()
    {
    }
}
