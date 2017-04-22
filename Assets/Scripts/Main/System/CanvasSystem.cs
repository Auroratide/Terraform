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
            config.planetUI.alpha = config.fadeAlpha;
        }

        public void UnfadePlanetUI() {
            config.planetUI.alpha = config.unfadeAlpha;
        }


        public void FadePlanet() {
            config.planet.alpha = config.fadeAlpha;
        }

        public void UnfadePlanet() {
            config.planet.alpha = config.unfadeAlpha;
        }


        public void FadeQuadrantsUI() {
            config.quadrantsUI.alpha = config.fadeAlpha;
        }

        public void UnfadeQuadrantsUI() { 
            config.quadrantsUI.alpha = config.unfadeAlpha;
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