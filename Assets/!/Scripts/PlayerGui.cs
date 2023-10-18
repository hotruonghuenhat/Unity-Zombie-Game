using UnityEngine;
using System.Collections;

public class PlayerGui : MonoBehaviour {

    // Tạo một texture2D
    public Texture2D _crosshair;

    // Sử dụng hàm OnGui để vẽ lên màn hình khi vào game
    void OnGUI()
    {
        // Vị trí x, y nằm giữa màn hình 
        float x = (Screen.width - _crosshair.width) / 2;
        float y = (Screen.height - _crosshair.height) / 2;
        // Vẽ teture tại một vị trí x, ytrên màn hình  
        GUI.DrawTexture(new Rect(x, y, _crosshair.width, _crosshair.height), _crosshair);
    }
}
