using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
    public class PlanetBehaviour : MonoBehaviour {
        
        private Planet planet;

        public void Awake() {
            planet = new Planet();
        }

        public void AddElementToTopLeft(IElement element) {
            planet.TopLeft.Add(element);
        }

        public void AddElementToTopRight(IElement element) {
            planet.TopRight.Add(element);
        }

        public void AddElementToBottomLeft(IElement element) {
            planet.BottomLeft.Add(element);
        }

        public void AddElementToBottomRight(IElement element) {
            planet.BottomRight.Add(element);
        }

        public void RenderTerrain() {
            Terrain terrain = new TerrainGenerator(planet).Generate();
            Debug.Log(terrain.ToString());


        }

    }
}