using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LessonBasic
{
    public class FirstLessonScript : MonoBehaviour
    {
        /// <summary>
        ///  C# variables
        /// </summary>
        // Start is called before the first frame update

        public int tamSayi = 1;
        [SerializeField] int tamSayi2 = 100;
        float ondalikSayi = 0.25f;
        float ondalikSayi2 = 5.2342f;
        bool dogru = true;
        bool yanlis = false;
        [SerializeField] private Vector3 ucFloat = new Vector3(1, 2, 3);

        // first lesson property
        public int MyProperty { get; set; }  // Property'lerin türü farklı olabilir. (int, float..)

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

