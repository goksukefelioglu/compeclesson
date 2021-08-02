using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        ///[SerializeField]private float _speed = 1;
        [SerializeField] private RotateSettings _rotateSettings;

        private void Update()
        { 
            /// Objeyi y ekseninde dondurecegimizi varsayalim.
            transform.Rotate(Vector3.up, _rotateSettings.Speed * Time.deltaTime);       /// *Time.deltaTime ile frame'ler arasındaki geçişi azaltıyoruz. Çünkü bu ne kadar az ise o kadar yavas doner. Boylece objenin dondugu gorulur.
            /// 100 frame per second " 100 * 0.1 " olur. (0.1, 1/100'den gelir)
            /// 50 frame per second " 50 * 0.2 " olur. (0.2, 1/50'den gelir)
        }
    }
}

