using System;
using UnityEngine;



    public class FollowPlayer : MonoBehaviour
    {
        private void LateUpdate()
        {
            GameObject player = GameObject.Find("Player");
            if (player == null)
            {
                return;
            }
            Vector3 target = player.transform.position + new Vector3(0f, 1.4f, 31f);
            transform.position = target;
        }
    }