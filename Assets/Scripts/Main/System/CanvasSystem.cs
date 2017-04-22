using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Auroratide.Terraform {
    public class CanvasSystem : MonoBehaviour {

        [SerializeField] private Config config;

        private RectTransform elementsUITransform;

        public void Awake() {
            elementsUITransform = config.elementsUI.GetComponent<RectTransform>();
        }

        public void RevealElementsUI() {
            //Vector3.Lerp(elementsUITransform.position, Vector3.zero, 1.0f);
            elementsUITransform.Translate(new Vector3(0, config.canvas.GetComponent<RectTransform>().rect.height, 0));
        }

        public void HideElementsUI() {
            elementsUITransform.Translate(new Vector3(0, -config.canvas.GetComponent<RectTransform>().rect.height, 0));
        }

        [System.Serializable] public class Config {
            public Canvas canvas;
            public CanvasGroup elementsUI;
        }

    }
}