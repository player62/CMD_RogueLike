using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class PlayerController : MonoBehaviour
    {
        private float cooldown = 0.5f; // 공격 쿨다운
        private float lastSwing;

        public float speed; // 캐릭터 이동 속도
        private Animator animator;

        Vector2 movement;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            // GetAxisRaw를 통해 Player의 움직임 정보 읽기
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            // GetAxisRaw로 읽어온 값을 통해 Animation 결정
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

            // 스페이스바를 누르면 공격
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // 쿨다운 시간이 지났는지 확인
                if (Time.time - lastSwing > cooldown)
                {
                    lastSwing = Time.time;
                    ATK();
                }
            }

            //animator.SetBool("IsMoving", movement.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * movement;
        }

        private void ATK()
        {
            // Animator에서 설정했던 Trigger 파라미터를 작동
            animator.SetTrigger("ATK");
        }
    }
}
