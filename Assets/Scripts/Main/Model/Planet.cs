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

        public List<AppliedElement> ElementApplications() {
            List<AppliedElement> elements = new List<AppliedElement>();

            foreach(IElement elem in TopLeft.Elements())
                elements.Add(new AppliedElement(elem, 1));
            foreach(IElement elem in TopRight.Elements())
                elements.Add(new AppliedElement(elem, 3));
            foreach(IElement elem in BottomRight.Elements())
                elements.Add(new AppliedElement(elem, 5));
            foreach(IElement elem in BottomLeft.Elements())
                elements.Add(new AppliedElement(elem, 7));

            return elements;
        }
    }

}