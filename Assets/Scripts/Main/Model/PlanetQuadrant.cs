using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
    public class PlanetQuadrant {
        private List<IElement> elements;

        public PlanetQuadrant():this(new List<IElement>()) {}

        public PlanetQuadrant(List<IElement> elements) {
            this.elements = elements;
        }

        public void Add(IElement element) {
            elements.Add(element);
        }
    }
}