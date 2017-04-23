using System;
using System.Collections.Generic;

namespace Auroratide.Terraform {
    public class TerrainGenerator {

        private Planet planet;

        public TerrainGenerator(Planet planet) {
            this.planet = planet;
        }

        public Terrain Generate() {
            Terrain terrain = new Terrain();
            List<AppliedElement> elements = planet.ElementApplications();
            foreach(AppliedElement element in elements) 
                terrain.Apply(element.element, element.angle);

            return terrain;
        }
    }
}
    