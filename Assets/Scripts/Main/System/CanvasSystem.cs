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

        public void ShowElementsUI() {
            //Vector3.Lerp(elementsUITransform.position, Vector3.zero, 1.0f);
            elementsUITransform.Translate(new Vector3(0, config.canvas.GetComponent<RectTransform>().rect.height, 0));
        }

        public void HideElementsUI() {
            elementsUITransform.Translate(new Vector3(0, -config.canvas.GetComponent<RectTransform>().rect.height, 0));
        }


        public void FadePlanetUI() {
            Fade(config.planetUI);
        }

        public void UnfadePlanetUI() {
            Unfade(config.planetUI);
        }


        public void FadePlanet() {
            Fade(config.planet);
        }

        public void UnfadePlanet() {
            Unfade(config.planet);
        }


        public void FadeQuadrantsUI() {
            Fade(config.quadrantsUI);
        }

        public void UnfadeQuadrantsUI() { 
            Unfade(config.quadrantsUI);
        }


        private void Fade(CanvasGroup group) {
            group.alpha = config.fadeAlpha;
            group.interactable = false;
        }

        private void Unfade(CanvasGroup group) {
            group.alpha = config.unfadeAlpha;
            group.interactable = true;
        }


    /*  Configuration
     *  =====================================================================================*/
        [System.Serializable] public class Config {
            public Canvas canvas;
            public CanvasGroup elementsUI;
            public CanvasGroup planetUI;
            public CanvasGroup planet;
            public CanvasGroup quadrantsUI;

            public float fadeAlpha = 0.05f;
            public float unfadeAlpha = 1.0f;
        }

    }
}