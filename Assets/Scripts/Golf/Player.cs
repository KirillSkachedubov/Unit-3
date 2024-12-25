using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

namespace Golf
{

    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;

        private Vector3 m_lastPosition;

        private bool m_isDown = false;

        public float range = 40f;

        public float speed = 500f;

        public float power = 20f;

        private void Update()
        {
            m_lastPosition = helper.position;
            m_isDown = Input.GetMouseButton(0);

            Quaternion rot = stick.localRotation;

            Quaternion toRot = Quaternion.Euler(m_isDown ? -range : range, 0, 0);

            rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);

            stick.localRotation = rot;
        }


        public void OnCollisionStick(Collider collider)
        {
            if (collider.TryGetComponent(out Rigidbody body))
            {
            
                var dir = (helper.position - m_lastPosition).normalized;
                body.AddForce(dir * power, ForceMode.Impulse);
            }


            Debug.Log(collider, this);
        }
    }
}