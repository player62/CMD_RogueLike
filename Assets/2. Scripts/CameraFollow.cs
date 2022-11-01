using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    // Player의 움직임에 따라 Main Camera를 이동
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform target; // target -> Player
        [SerializeField] private float lerpSpeed = 1.0f; // Main Camera가 Player를 따라오는 속도

        private Vector3 offset;
        private Vector3 targetPos;

        private void Start()
        {
            if (target == null) return;

            offset = transform.position - target.position;
        }

        private void Update()
        {
            if (target == null) return;

            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime); // 현재 Main Camera의 위치와 targetPos을 선형보간
        }

    }
}