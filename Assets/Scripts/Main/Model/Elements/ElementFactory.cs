using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Auroratide.Terraform {

    public class ElementFactory {

        public static IElement Create(string name) {
            if(name == "fire")
                return new FireElement();
            else {
                Debug.LogWarning("Attempted to create " + name + ", but this element does not exist");
                return null;
            }
        }

    }

}