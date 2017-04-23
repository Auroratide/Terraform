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
            config.planet.RenderTerrain();
        }

        public void AddElementToTopRight() {
            Debug.Log("Adding " + activeElement.ToString() + " to Top Right");
            config.planet.AddElementToTopRight(activeElement);
            canvas.FadeQuadrantsUI();
            canvas.UnfadePlanetUI();
            config.planet.RenderTerrain();
        }

        public void AddElementToBottomLeft() {
            Debug.Log("Adding " + activeElement.ToString() + " to Bottom Left");
            config.planet.AddElementToBottomLeft(activeElement);
            canvas.FadeQuadrantsUI();
            canvas.UnfadePlanetUI();
            config.planet.RenderTerrain();
        }

        public void AddElementToBottomRight() {
            Debug.Log("Adding " + activeElement.ToString() + " to Bottom Right");
            config.planet.AddElementToBottomRight(activeElement);
            canvas.FadeQuadrantsUI();
            canvas.UnfadePlanetUI();
            config.planet.RenderTerrain();
        }

        public void SetElement(IElement element) {
            this.activeElement = element;
        }

        [System.Serializable] public class Config {
            public PlanetBehaviour planet;
        }

    }
}