using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    [RequireComponent (typeof(CanvasSystem))]
    public class CanvasBehaviour : MonoBehaviour {

        private CanvasSystem canvas;

        public void Awake() {
            canvas = GetComponent<CanvasSystem>();
        }

        public void Start() {
            canvas.FadeQuadrantsUI();
        }

    }
}