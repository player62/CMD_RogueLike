using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    // Gradient 클래스를 이용해 효과 추가
    public class SpriteColorAnimation : MonoBehaviour
    {
        [SerializeField] private Gradient gradient;
        [SerializeField] private float time;

        private SpriteRenderer spriteRenderer;
        private float timer;

        private void Start()
        {
            timer = time * Random.value;
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (spriteRenderer)
            {
                timer += Time.deltaTime;
                if (timer > time) timer = 0.0f;

                spriteRenderer.color = gradient.Evaluate(timer / time);
            }
        }
    }
}
