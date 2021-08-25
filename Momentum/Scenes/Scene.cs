using Chroma.Graphics;
using Chroma.Input;

namespace Momentum { 
    public abstract class Scene
    {
        public virtual void Draw(RenderContext context)
        {

        }
        public virtual void Update(float delta)
        {

        }
        public virtual void KeyPressed(KeyEventArgs e)
        {

        }
        public virtual void KeyReleased(KeyEventArgs e)
        {

        }
        public virtual void TextInput(TextInputEventArgs e)
        {

        }
        public virtual void MouseMoved(MouseMoveEventArgs e)
        {

        }
        public virtual void MousePressed(MouseButtonEventArgs e)
        {

        }
        public virtual void MouseReleased(MouseButtonEventArgs e)
        {

        }
    }
}