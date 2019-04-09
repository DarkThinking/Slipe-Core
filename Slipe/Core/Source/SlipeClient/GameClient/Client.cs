﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MtaDefinitions;
using Slipe.Client.Sounds;
using Slipe.Client.Rendering;
using Slipe.Client.IO;

namespace Slipe.Client.GameClient
{
    /// <summary>
    /// Static class that handles calls to functions related to the client
    /// </summary>
    public static class Client
    {
        /// <summary>
        /// Get the renderer object
        /// </summary>
        public static Renderer Renderer
        {
            get
            {
                return Renderer.Instance;
            }
        }

        /// <summary>
        /// Get the Engine object
        /// </summary>
        public static Engine Engine
        {
            get
            {
                return Engine.Instance;
            }
        }

        /// <summary>
        /// Returns the MTA F8 console
        /// </summary>
        private static MTAConsole console;
        public static MTAConsole Console
        {
            get
            {
                if (console == null)
                {
                    console = new MTAConsole();
                }
                return console;
            }
        }

        /// <summary>
        /// Returns the MTA debug view
        /// </summary>
        private static MTADebug debug;
        public static MTADebug Debug
        {
            get
            {
                if (debug == null)
                {
                    debug = new MTADebug();
                }
                return debug;
            }
        }

        /// <summary>
        /// Get if voice is currently enabled
        /// </summary>
        public static bool IsVoiceEnabled
        {
            get
            {
                return MtaShared.IsVoiceEnabled();
            }
        }

        /// <summary>
        /// Get and set the radio channel that's playing on the client (even when not in a vehicle)
        /// </summary>
        public static RadioStation ActiveRadioStation
        {
            get
            {
                return (RadioStation)MtaClient.GetRadioChannel();
            }
            set
            {
                MtaClient.SetRadioChannel((int)value);
            }
        }

        /// <summary>
        /// Get and set if the input is focused on Gui elements
        /// </summary>
        public static bool GuiInputEnabled
        {
            get
            {
                return MtaClient.GuiGetInputEnabled();
            }
            set
            {
                MtaClient.GuiSetInputEnabled(value);
            }
        }

        /// <summary>
        /// Get and set the input mode
        /// </summary>
        public static InputMode InputMode
        {
            get
            {
                return (InputMode) Enum.Parse(typeof(InputMode), MtaClient.GuiGetInputMode(), true);
            }
            set
            {
                MtaClient.GuiSetInputMode(value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Get whether the user is in the main menu or not
        /// </summary>
        public static bool IsMainMenuActive
        {
            get
            {
                return MtaClient.IsMainMenuActive();
            }
        }

        /// <summary>
        /// Get if any system windows that take focus are active.
        /// </summary>
        public static bool IsMtaWindowActive
        {
            get
            {
                return MtaClient.IsMTAWindowActive();
            }
        }

        /// <summary>
        /// Get if the download box is active
        /// </summary>
        public static bool IsTransferBoxActive
        {
            get
            {
                return MtaClient.IsTransferBoxActive();
            }
        }
    }
}