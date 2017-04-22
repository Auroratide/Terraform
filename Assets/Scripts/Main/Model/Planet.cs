using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {
       
    public class Planet {
        private PlanetQuadrant topLeft;
        private PlanetQuadrant topRight;
        private PlanetQuadrant bottomLeft;
        private PlanetQuadrant bottomRight;

        public PlanetQuadrant TopLeft {
            get {  return topLeft; }
        }

        public PlanetQuadrant TopRight {
            get {  return topRight; }
        }

        public PlanetQuadrant BottomLeft {
            get {  return bottomLeft; }
        }

        public PlanetQuadrant BottomRight {
            get {  return bottomRight; }
        }

        public Planet():this(new PlanetQuadrant(), new PlanetQuadrant(), new PlanetQuadrant(), new PlanetQuadrant()) {}

        public Planet(PlanetQuadrant topLeft, PlanetQuadrant topRight, PlanetQuadrant bottomLeft, PlanetQuadrant bottomRight) {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
    }

}