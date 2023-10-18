using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    CharacterController _controller; // Nhân vật 
    Transform _player; // Tìm vị trí của Player 
	// Biến tốc độ di chuyển 
    public float _moveSpeed = 5.0f;

    // Khai báo thêm biến trọng lực và biến phụ y_Velocity
    public float _gravity = 2.0f;
     float _yVelocity = 0.0f;


	void Start () {
     //Tìm nhân vật có Tag là Player, không tìm theo tên vì có 2 Player  
	 GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
     _player = playerGameObject.transform; // Lấy transform của nhân vật 

      // Controller của Enemy 
     _controller = GetComponent<CharacterController>();
	}

    void Update()
    {
        // hướng = vị trí người chơi - vị trí đối thủ 
        Vector3 direction = _player.position - transform.position;
        direction.Normalize(); // Chuyển về vector cùng phương, có độ lớn = 1
        // Tăng tốc 
        Vector3 velocity = direction * _moveSpeed;
        // Nếu khác mặt đất     
        if (!_controller.isGrounded)
        {
            // chiều y sẽ giảm xuống 
            _yVelocity -= _gravity;
        }
        velocity.y = _yVelocity; // gán lại vị trí chiều y 

        direction.y = 0; // gán hướng chiều y = 0 (không dùng hướng y)
        // gán rotation của Enemy quay theo hướng Player 
        transform.rotation = Quaternion.LookRotation(direction);

        // Di chuyển theo tốc độ 
        _controller.Move(velocity * Time.deltaTime);
    }
}
