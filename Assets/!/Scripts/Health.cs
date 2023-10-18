using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    Animation _animation;

    public int  _maximumHealth = 100; // Năng lượng cực đại 
    int _currentHealth = 0; // Năng lượng hiện hành 
	void Start () {
        // Gán năng lượng hiện hành bằng cực đại 
        _currentHealth = _maximumHealth;

        _animation = GetComponentInChildren<Animation>();
	}
    // Phương thức hủy đối tượng game khi bị bắn 
    public void Damage(int damageValue) 
    {
        // mỗi lần bị bắn, _currentHealth bị sụt giảm  
        _currentHealth -= damageValue;
        if (_currentHealth <= 0) // Nếu _currentHealth <=0 
        {
            // Chế độ lặp lại 
            _animation["Die"].wrapMode = WrapMode.Once;
            // Chạy clip này 
            _animation.Play("Die");
            // Xác định thời điểm Move1 bắt đầu thực hiện 
            _animation["Die"].normalizedTime = Random.value;
           Destroy(gameObject,2.6f); // thì hủy đối tượng  

        }
    }
}
