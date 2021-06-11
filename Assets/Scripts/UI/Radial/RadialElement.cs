﻿using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Inventory.Items;

namespace Assets.Scripts.UI.Radial
{
    public class RadialElement : MonoBehaviour
    {
        public Image Icon;
        public Image CakePiece;
        public TMP_Text IconText;
        public TMP_Text Number;

        [HideInInspector] public Item thisItem;
        [HideInInspector] public Inventory.InventoryItem thisInventoryItem;

        public RadialMenu NextMenu;
        [HideInInspector] public RadialMenu PreviousMenu;

        private const float Speed = 8f;

        public void Animate()
        {
            StartCoroutine(GrowButton());
        }

        private IEnumerator GrowButton()
        {
            transform.localScale = Vector3.zero;
            float timer = 0f;
            while (timer < (1 / Speed))
            {
                timer += Time.deltaTime;
                transform.localScale = Vector3.one * timer * Speed;
                yield return null;
            }
            transform.localScale = Vector3.one;
        }
    }
}
