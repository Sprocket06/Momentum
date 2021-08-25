using System;
using System.IO;
using Chroma;
using Chroma.ContentManagement;
using Chroma.ContentManagement.FileSystem;
using Chroma.Diagnostics.Logging;
using Chroma.Graphics;

namespace Momentum
{
    class GameCore : Game
    {
        public static Log Log { get; private set; }
        public static IContentProvider Content { get; private set; }

        public GameCore()
        {
            Log = LogManager.GetForCurrentAssembly();
            Content = new FileSystemContentProvider(Path.Combine(AppContext.BaseDirectory, "Assets"));
        }

        protected override void Draw(RenderContext context)
        {
            SceneManager.ActiveScene.Draw(context);
        }

        protected override void Update(float delta)
        {
            SceneManager.ActiveScene.Update(delta);
        }
        
        
    }
}