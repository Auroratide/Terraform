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

    }
}