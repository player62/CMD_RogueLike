using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//when something get into the alta, make the runes glow
namespace Cainos.PixelArtTopDown_Basic
{

    public class PropsAltar : MonoBehaviour
    {
        // Altar 하위의 룬 문자를 리스트로 읽기
        public List<SpriteRenderer> runes;
        public float lerpSpeed;

        private Color currentColor;
        private Color targetColor;

        // 시간에 따라 Alpha 영역(투명도)을 조절해 효과 추가
        private void OnTriggerEnter2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 1);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            targetColor = new Color(1, 1, 1, 0);
        }

        private void Update()
        {
            currentColor = Color.Lerp(currentColor, targetColor, lerpSpeed * Time.deltaTime);

            foreach (var rune in runes)
            {
                rune.color = currentColor;
            }
        }
    }
}
