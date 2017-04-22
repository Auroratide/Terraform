using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
    public class QuadrantsUIController : Controller {

        [SerializeField] private Config config;
        private IElement activeElement;

        public void AddElementToTopLeft() {
            Debug.Log("Adding " + activeElement.ToString() + " to Top Left");
            config.planet.AddElementToTopLeft(activeElement);
            canvas.FadeQuadrantsUI();
            canvas.UnfadePlanetUI();
        }

        public void SetElement(IElement element) {
            this.activeElement = element;
        }

        [System.Serializable] public class Config {
            public PlanetBehaviour planet;
        }

    }
}