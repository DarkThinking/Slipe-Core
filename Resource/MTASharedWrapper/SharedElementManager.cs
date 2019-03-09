﻿using MultiTheftAuto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTASharedWrapper
{
    public class SharedElementManager
    {
        private static SharedElementManager instance;
        public static SharedElementManager Instance
        {
            get
            {
                return instance ?? new SharedElementManager();
            }
        }


        private SharedElement root;
        public SharedElement Root { get { return root; } }

        private Dictionary<System.Object, SharedElement> elements;

        public SharedElementManager()
        {
            instance = this;
            elements = new Dictionary<System.Object, SharedElement>();
            root = new SharedElement(Shared.GetRootElement());
        }

        public void RegisterElement(SharedElement element)
        {
            elements.Add(element.MTAElement, element);
        }

        public SharedElement GetElement(Element element)
        {
            if (!this.elements.ContainsKey(element))
            {
                return null;
            }
            return this.elements[element];
        }

        protected internal void AddEventHandler(SharedElement element, string eventName, bool propagated = true, string priorty = "normal")
        {
            Shared.AddEventHandler(eventName, element.MTAElement, "MTASharedWrapper.SharedElementManager.HandleEvent", propagated, priorty);
        }

        public static void HandleEvent(string eventString, Element source, dynamic p1, dynamic p2, dynamic p3, dynamic p4, dynamic p5, dynamic p6, dynamic p7, dynamic p8)
        {
            SharedElement element = Instance.GetElement(source);
            if (element == null)
            {
                // if the resource is not aware of the referenced element's existance have the root element handle it instead
                // this is particularly useful for playerJoin, since the player element will not exist before that yet
                SharedElement.Root.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
                return;
            }
            element.HandleEvent(eventString, source, p1, p2, p3, p4, p5, p6, p7, p8);
        }

    }
}
