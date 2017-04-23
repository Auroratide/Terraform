using System;
using System.Collections.Generic;

namespace Auroratide.Terraform {
    public class TerrainRenderer {

        private Terrain terrain;

        public TerrainRenderer(Terrain terrain) {
            this.terrain = terrain;
        }

        public List<IPlanetProperty> BuildGlobalProperties() {

            return null;
        }

        public List<IPlanetProperty> BuildOctantProperties(int octant) {
            List<IPlanetProperty> properties = new List<IPlanetProperty>();
            if(terrain.Temperature(octant) > 10) {
                properties.Add(new HasMagma());
            }

            return properties;
        }
    }
}

