using UnityEngine;
using System.Collections;

public class RifleWeapon : MonoBehaviour {

    public int _damageDealt = 50;
	// Use this for initialization

	void Start () {
        Screen.lockCursor = true; // Khóa chuột 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            Screen.lockCursor = false;
        }

        // Người dùng nhấn chuột trái (phím Fire1 với máy chơi game)
        if (Input.GetButtonDown("Fire1"))
        {
            Screen.lockCursor = true;

            // Vẽ một tia vô hình bắt đầu từ giữa Camera
            // Vị trí (0.5, 0.5, 0) thể hiện giữa màn hình camera với trục X, Y. 
            Ray mouseRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo; // Lưu giữ thông tin va chạm 
            if (Physics.Raycast(mouseRay, out hitInfo)) // Nếu có giao cắt 
            {
                // Lấy class Health từ thành phần của đối tượng khi có giao điểm
                Health enemyHealth = hitInfo.transform.GetComponent<Health>();
                if (enemyHealth != null) // Nếu có thành phần đó 
                {
                    // Gọi phương thức hủy
                    enemyHealth.Damage(_damageDealt);
                }
            }
        }
	}
}
