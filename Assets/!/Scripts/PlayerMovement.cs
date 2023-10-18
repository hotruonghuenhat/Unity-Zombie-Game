using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    // Khai báo đối tượng Character Controller 
    CharacterController _characterController;
    // Tốc độ di chuyển của Player 
    public float _moveSpeed = 5.0f;
    // Độ cao của bước nhảy. 
    public float _jumpSpeed = 20.0f;
    // Giá trị trọng lực     
     float _gravity = 1.0f;
    // giá trị theo chiều trục y  
     float _yVelocity = 0.0f;

     void Start()
     {
         // Lấy Character Controller từ Player 
         _characterController = GetComponent<CharacterController>();
     }
	
	void Update () {
      // Khai báo một Vector hướng, lấy giá trị khi người dùng nhấn phím mũi tên  
	  Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
      Vector3 velocity = direction * _moveSpeed; // Nhân với tốc độ và deltaTime
         
         if (_characterController.isGrounded) // Nếu đang ở mặt đất 
         {
             if (Input.GetButtonDown("Jump"))  // mà người dùng nhấn phím SpaceBar 
             {
                 _yVelocity = _jumpSpeed;    // Thì gán giá trị trục y lên độ cao jumpSpeed; 
             }
         }
         else _yVelocity -= _gravity; // Nếu không ở mặt đất thì giảm độ cao dần dần (rơi). 
         velocity.y = _yVelocity;  // gán giá trị y của vector vận tốc.  
         velocity = transform.TransformDirection(velocity);
         _characterController.Move(velocity*Time.deltaTime); // nhân vật di chuyển 
	}
 
}
