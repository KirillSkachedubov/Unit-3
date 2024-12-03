using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TZ
{
    public class CloudController : MonoBehaviour
    {
        private int m_targetIndex = 0;
        private bool m_moved = false;
        public float moveSpeed = 10f;
        public Transform cloud;
        public Transform[] targets;
        public void Action()
        {
            Debug.Log("Cloud", this);

            if (m_moved)
            {
                return;
            }
            m_moved = true;
            m_targetIndex++;
            if (m_targetIndex >= targets.Length) { m_targetIndex = 0; }
        }
        public void Update()
        {
            if (!m_moved)
            {
                return;
            }
            Transform target = targets[m_targetIndex];
            Vector3 targetPosition = new Vector3(target.position.x, cloud.position.y, target.position.z);
            Vector3 offset = (targetPosition - cloud.position).normalized * Time.deltaTime * moveSpeed;
            if(Vector3.Distance(cloud.position, targetPosition) < offset.magnitude)
            {
                cloud.position = targetPosition;
                m_moved = false;
            }
            else
            {
                cloud.Translate(offset);
            }
        }
    }
}
