using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    // 오브젝트가 trigger를 벗어날 때, 레이어를 변경해줌
    // 계단을 올라가거나 내려갈 때 오브젝트의 층을 변경
    public class LayerTrigger : MonoBehaviour
    {
        public string layer;
        public string sortingLayer;

        private void OnTriggerExit2D(Collider2D other) // 오브젝트(Player)가 trigger를 벗어날 때, 오브젝트를 other에 저장
        {
            // 오브젝트의 레이어를 충돌한 레이어의 번호로 변경(계단을 올라갈 때는 +1, 내려갈 때는 -1)
            other.gameObject.layer = LayerMask.NameToLayer(layer);

            // 오브젝트의 모든 Children에 대해서도 같은 작업을 반복
            other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = sortingLayer;
            SpriteRenderer[] srs = other.gameObject.GetComponentsInChildren<SpriteRenderer>();
            foreach ( SpriteRenderer sr in srs)
            {
                sr.sortingLayerName = sortingLayer;
            }
        }

    }
}