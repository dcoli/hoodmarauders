﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

using GoblinXNA;
using GoblinXNA.Graphics;
using GoblinXNA.SceneGraph;
using Model = GoblinXNA.Graphics.Model;
using GoblinXNA.Graphics.Geometry;
using GoblinXNA.Device.Generic;
using GoblinXNA.Physics;
using GoblinXNA.Helpers;

using GoblinXNA.UI.UI2D;
using GoblinXNA.UI.Events;

using GoblinXNA.Device.Capture;
using GoblinXNA.Device.Vision;
using GoblinXNA.Device.Vision.Marker;

namespace Manhattanville
{
    class AirRightsGraph : TransformNode
    {
        public AirRightsGraph()
        {
            this.Translation = new Vector3(Settings.GraphX, Settings.GraphY, Settings.GraphZ);

            TransformNode transNode = new TransformNode();
            transNode.Translation = new Vector3(0, 0, -1);

            GeometryNode displayShelf = new GeometryNode();
            displayShelf.Model = new Model((new TexturedBox(80,20,1)).Mesh);
            
            Material mat = new Material();
            mat.Diffuse = Color.White.ToVector4(); //Color.DarkSlateBlue.ToVector4();
            //mat.Specular = Color.White.ToVector4();
            //mat.SpecularPower = 10;
            mat.Texture = Manhattanville.airTex;

            displayShelf.Material = mat;

            this.AddChild(transNode);
            transNode.AddChild(displayShelf);
        }
    }
}
