using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Auroratide.Terraform {

    [RequireComponent (typeof(RectTransform))]
    public class PlanetBehaviour : MonoBehaviour {

        [SerializeField] private Config config;

        private Planet planet;

        private RectTransform rect;

        public void Awake() {
            planet = new Planet();
            rect = GetComponent<RectTransform>();
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
            ClearPropertyImages();
            Terrain terrain = new TerrainGenerator(planet).Generate();
            Debug.Log(terrain.ToString());

            TerrainRenderer renderer = new TerrainRenderer(terrain);
            List<IPlanetProperty> props = new List<IPlanetProperty>();

            for(int i = 0; i < 8; ++i) 
                props.AddRange(renderer.BuildOctantProperties(i));
            foreach(IPlanetProperty prop in props)
                prop.Render(CreatePropertyImage());
        }

        public void ClearPropertyImages() {
            Transform parent = config.propertyContainer.transform;
            List<GameObject> imagesToDestroy = new List<GameObject>();
            for(int i = 0; i < parent.childCount; ++i) 
                imagesToDestroy.Add(parent.GetChild(i).gameObject);
            parent.DetachChildren();
            foreach(GameObject child in imagesToDestroy) 
                DestroyObject(child);
        }

        public Image CreatePropertyImage() {
            Image image = Instantiate(config.imageTemplate);
            image.gameObject.transform.SetParent(config.propertyContainer.transform);
            RectTransform rect = image.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(config.planetTransform.rect.width, config.planetTransform.rect.height);
            rect.anchoredPosition = new Vector2();

            return image;
        }

        [System.Serializable] public class Config {
            public GameObject propertyContainer;
            public RectTransform planetTransform;
            public Image imageTemplate;
        }

    }
}