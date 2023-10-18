using UnityEngine;
using System.Collections;

public class EnemyAnimation : MonoBehaviour {
    
    // Tạo một Animation 
    Animation _animation;
	void Start () {
        // Lấy thành phần Animation từ Zombie, do script gắn vào Enemy
	  _animation = GetComponentInChildren<Animation>();

      string animationToPlay = ""; // biến điều khiển animation 
      switch (Random.Range(0, 3)) // Lấy ngẫu nhiên 1 giá trị từ 1 đến 3 
      {
          default:
             case 0:
             animationToPlay = "Move1";
             break;
         case 1:
             animationToPlay = "Move2";
             break;
         case 2:
             animationToPlay = "Move3";
             break;
      }
        // Chế độ lặp lại 
      _animation[animationToPlay].wrapMode = WrapMode.Loop;
        // Chạy clip này 
      _animation.Play(animationToPlay);
        // Xác định thời điểm Move1 bắt đầu thực hiện 
      _animation[animationToPlay].normalizedTime = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
